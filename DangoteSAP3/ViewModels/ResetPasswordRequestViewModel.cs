using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DangoteSAP3.ViewModels
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ResetPasswordRequestViewModel
    {
        [Required]
        public string Username {get; set; }
        [Required]
        public string Password {get; set; }
        [Required]
        public string NewPassword {get; set; }
        [Required]
        public string NewPasswordConfirmation {get; set; }
    }
}