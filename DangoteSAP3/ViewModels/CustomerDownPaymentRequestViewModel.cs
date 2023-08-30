using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DangoteSAP3.ViewModels
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CustomerDownPaymentRequestViewModel
    {
        [Required]
        public string CompCode {get; set;}
        [Required]
        public string TellerNo {get; set;}
        [Required]
        public string Bankn {get; set;}
        [Required]
        public string CustNumber {get; set;}
        [Required]
        public string Amount {get; set;}
        [Required]
        public string TranId {get; set;}
        [Required]
        public string AccessToken {get; set;}
        [Required]
        public string Currency {get; set;}
    }
}