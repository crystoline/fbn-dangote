using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DangoteSAP3.ViewModels
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class LoginRequestViewModel
    {
        [Required]
        [Display(Name = "username", ShortName = "username")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string fullSync { get; set; } = "1";

    }
}