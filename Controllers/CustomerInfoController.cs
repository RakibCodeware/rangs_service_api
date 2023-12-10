using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangsServiceApi.Db;

namespace RangsServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerInfoController : ControllerBase
    {
       
        [HttpGet]
        [Route("getcustomerInfo")]
        public async Task<IActionResult> getCustomerInfo()
        {
            using (var dbContext = new VirtualDbContext()) 
            {
                var result = await (from m in dbContext.Mrsrmasters
                                    join md in dbContext.Mrsrdetails on m.Mrsrmid equals md.Mrsrmid
                                    join p in dbContext.Products on md.ProductId equals p.ProductId
                                    join c in dbContext.Customers on m.Customer equals c.Mobile
                                    join e in dbContext.Entities on m.OutSource equals e.Eid
                                    where !string.IsNullOrEmpty(m.Customer) && !string.IsNullOrEmpty(c.CustName) &&
                                          c.CustName == "Sumon" && c.Mobile == "01761549044" && m.Mrsrcode=="102004/2023/00001"
                                    select new
                                    {
                                        CustName = c.CustName,
                                        Email = c.Email,
                                        Mobile = c.Mobile,
                                        Address = c.Address,
                                        DelivaryFrom = e.EName,
                                        OutSource = m.OutSource,
                                        InSource = m.InSource,
                                        DelivaryTo = c.Address,
                                        PurchasesDate = m.Tdate,
                                        GroupName = p.GroupName,
                                        Model = p.Model,
                                        Code = p.Code,
                                        ProdName = p.ProdName,
                                        ModelSerial = p.ModelSerial,
                                        MRSRCode = m.Mrsrcode,
                                        TermsCondition = m.TermsCondition
                                    }).ToListAsync();

                return Ok(result);
            }
            

        }
    }
}
