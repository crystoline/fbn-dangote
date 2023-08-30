using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DangoteSAP3.ViewModels
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class OrderRequestViewModel
    {
        [Required]
        public string CustNum {get; set;}
        [Required]
        public string Materials {get; set;}
        [Required]
        public string Quantities {get; set;}
        [Required]
        public string Plant {get; set;}
        [Required]
        public string DelvStatus {get; set;}
        [Required]
        public string SalesOrg {get; set;}
        [Required]
        public string TranId {get; set;}
        [Required]
        public string Division {get; set;}
        [Required]
        public string AcessToken {get; set;}
        [Required]
        public string City {get; set;}
        [Required]
        public string Street {get; set;}
        [Required]
        public string Country {get; set;}
        [Required]
        public string Region {get; set;}
        [Required]
        public string CustName {get; set;}
    }
}