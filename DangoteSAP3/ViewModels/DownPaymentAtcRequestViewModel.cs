using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DangoteSAP3.ViewModels
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class DownPaymentAtcRequestViewModel
    {
        [Required]
        public string CustNum {get; set;}
        [Required]
        public string Material {get; set;}
        [Required]
        public string Quantity {get; set;}
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
        public string AccessToken {get; set;}
        [Required]
        public string DestCity {get; set;}
        [Required]
        public string DestAddress {get; set;}
        [Required]
        public string DestCountry {get; set;}
        [Required]
        public string DestRegion {get; set;}
        [Required]
        public string ReceiverName {get; set;}
        [Required]
        public string CompCode {get; set;}
        [Required]
        public string TellerNo {get; set;}
        [Required]
        public string Amount {get; set;}
        [Required]
        public string Bankn {get; set;}
        [Required]
        public string SplitType {get; set;}
        [Required]
        public string Currency {get; set;}
        [Required]
        public string OrderAmount {get; set;}
    }
}