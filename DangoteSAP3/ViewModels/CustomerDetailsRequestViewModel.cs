using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DangoteSAP3.ViewModels
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CustomerDetailsRequestViewModel
    {
        [Required] 
        public string CompCode {get; set;}
        [Required] 
        public string CustNum {get; set;}
        [Required] 
        public string CcArea {get; set;}
        [Required] 
        public string SalesOrg {get; set;}
        [Required] 
        public string AccessToken {get; set;}
    }
}