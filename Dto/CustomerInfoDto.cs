using Newtonsoft.Json;

namespace RangsServiceApi.Dto
{
    public class CustomerInfoDto
    {
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress { get; set; }
        
        [JsonProperty("CustomerMobile")]
        public string CustomerMobile { get; set; }
        
        [JsonProperty("CustomerEmail")]
        public string CustomerEmail { get; set; }

        

        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; }

        [JsonProperty("DeliveryFrom")]
        public string DeliveryFrom { get; set; }

        [JsonProperty("DeliveryTo")]
        public string DeliveryTo { get; set; }

        [JsonProperty("GroupName")]
        public string GroupName { get; set; }

        [JsonProperty("InvoiceNo")]
        public string InvoiceNo { get; set; }

        [JsonProperty("ModelName")]
        public string ModelName { get; set; }

        [JsonProperty("ProductCode")]
        public string ProductCode { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("PurchaseDate")]
        public DateTime PurchaseDate { get; set; }

        [JsonProperty("ProductSerial")]
        public string ProductSerial { get; set; }

        [JsonProperty("WarrantyInfo")]
        public string WarrantyInfo { get; set; }
        [JsonProperty("Category")]
        public string Category { get; set; }


        //this is for service api
        public int ServiceWarranty { get; set; }
        public int GeneralPartsWarranty { get; set; }
        public int SpecialPartsWarranty { get; set; }
    }
}
