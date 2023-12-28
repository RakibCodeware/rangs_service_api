using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangsServiceApi.Db;
using RangsServiceApi.Dto;
using System.Text.RegularExpressions;

namespace RangsServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerInfoController : ControllerBase
    {
       
        [HttpGet]
        [Route("getcustomerInfo")]


        public async Task<IActionResult> GetCustomerInfo(string custname = null, string mobileNumber = null, string invoice = null, string serialNumber = null)
        {
            try
            {
                using (var dbContext = new VirtualDbContext())
                {
                    var query = from m in dbContext.Mrsrmasters
                                join md in dbContext.Mrsrdetails on m.Mrsrmid equals md.Mrsrmid
                                join p in dbContext.Products on md.ProductId equals p.ProductId
                                join c in dbContext.Customers on m.Customer equals c.Mobile
                                join e in dbContext.Entities on m.OutSource equals e.Eid
                                select new CustomerInfoDto
                                {
                                    CustomerAddress = c.Address,
                                    CustomerEmail = c.Email,
                                    CustomerMobile = c.Mobile,
                                    CustomerName = c.CustName,
                                    DeliveryFrom = e.EName,
                                    DeliveryTo = c.Address,
                                    GroupName = p.GroupName,
                                    InvoiceNo = m.Mrsrcode,
                                    ModelName = p.Model,
                                    ProductCode = p.Code,
                                    ProductName = p.ProdName,
                                    PurchaseDate = (DateTime)m.Tdate,
                                    ProductSerial = md.Slno,
                                    WarrantyInfo = m.TermsCondition,
                                    Category=p.Pcategory
                                };

                    if (string.IsNullOrEmpty(custname) && string.IsNullOrEmpty(mobileNumber) && string.IsNullOrEmpty(invoice) && string.IsNullOrEmpty(serialNumber))
                    {
                        // when no parameter is given, show this message
                        return BadRequest(new { StatusCode = "400", Message = "At least one parameter is required." });
                    }

                    // Apply filters if parameters are provided
                    if (!string.IsNullOrEmpty(custname))
                    {
                        query = query.Where(c => c.CustomerName == custname);
                    }

                    if (!string.IsNullOrEmpty(mobileNumber))
                    {
                        query = query.Where(c => c.CustomerMobile == mobileNumber);
                    }

                    if (!string.IsNullOrEmpty(invoice))
                    {
                        query = query.Where(m => m.InvoiceNo == invoice);
                    }

                    if (!string.IsNullOrEmpty(serialNumber))
                    {
                        query = query.Where(m => m.ProductSerial == serialNumber);
                    }

                    var result = await query.ToListAsync();

                    if (result != null && result.Any())
                    {
                        // Apply the warranty extraction logic for each result
                        foreach (var item in result)
                        {
                            ApplyWarrantyExtraction(item);
                        }

                        return Ok(result);
                    }

                    return NotFound(new { StatusCode = "404", Message = "Data not found" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Helper method for broke Warranty info
        private void ApplyWarrantyExtraction(CustomerInfoDto item)
        {
            Regex serviceWarrantyRegex = new Regex(@"Service Warranty (\d+) Years");
            Regex panelWarrantyRegex = new Regex(@"Panel Warranty (\d+) Years");
            Regex partsWarrantyRegex = new Regex(@"Parts Warranty (\d+) Years");

            // Match the regular expressions to the warranty information
            Match serviceWarrantyMatch = serviceWarrantyRegex.Match(item.WarrantyInfo);
            Match panelWarrantyMatch = panelWarrantyRegex.Match(item.WarrantyInfo);
            Match partsWarrantyMatch = partsWarrantyRegex.Match(item.WarrantyInfo);

           //service warrenty
            item.ServiceWarranty = GetWarrantyYears(serviceWarrantyMatch);

            //Specialpartswarrenty
            item.SpecialPartsWarranty = GetWarrantyYears(panelWarrantyMatch);

            //generalPartswarrenty
            item.GeneralPartsWarranty = GetWarrantyYears(partsWarrantyMatch);
        }

        // Helper method to extract warranty years from a match
        private int GetWarrantyYears(Match match)
        {
            if (match.Success && match.Groups.Count > 1)
            {
                string yearsStr = match.Groups[1].Value;
                if (int.TryParse(yearsStr, out int years))
                {
                    return years;
                }
            }
            return 0; // defualt value pass
        }






    }

}

