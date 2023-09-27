namespace WeatherApp.Models
{
    public class UserModel
    {
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false, ErrorMessage = "This Feild is Required")]
        public int User_ID { get; set; }

        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false, ErrorMessage = "This Feild is Required")]
        public string username { get; set; } = String.Empty;

        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false, ErrorMessage = "This Feild is Required")]
        public string password { get; set; } = String.Empty;

        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false, ErrorMessage = "This Feild is Required")]
        public string email { get; set; } = String.Empty;


    }
}
