using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models
{
    public class SearchByCityModel
    {
        
        [Required(ErrorMessage ="City Name is Empty")]
        [Display(Name = "City Name")]
        [StringLength(30,MinimumLength =2,ErrorMessage ="Invalid Input, Lenght must be between 2 to 20 characters")]
        public string? CityName { get; set; }
    }
}
