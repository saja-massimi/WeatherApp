namespace WeatherApp.Models
{
    public class CityModel
    {
        [System.ComponentModel.DataAnnotations.Display(Name ="City Name:")]
        public string? name { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name ="Temp:")]
        public float Temprature { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name ="Humidity:")]
        public int Humiditiy { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Pressure:")]
        public int Pressure { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Wind Speed:")]
        public float Wind { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Weather Condition:")]
        public string? Weather { get; set; }
    }
}
