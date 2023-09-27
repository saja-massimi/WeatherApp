using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;
using WeatherApp.Repositories;

namespace WeatherApp.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWForecastRepository? _WForecastRepository;

        public WeatherForecastController(IWForecastRepository WForecastRepository)
        {
            _WForecastRepository = WForecastRepository;
        }
        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCityModel();
            return View();
        }

        [HttpPost]
        public IActionResult SearchByCity(SearchByCityModel model)
        {
            if (ModelState.IsValid)
               {
                return RedirectToAction("City", "WeatherForecast", new { city = model.CityName });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            WeatherResponse weatherResponse = _WForecastRepository.GetForecast(city);
            var viewModel = new CityModel();
            if(weatherResponse!=null)
            {
                viewModel.name = weatherResponse.name;
                viewModel.Temprature = weatherResponse.Main.Temp;
                viewModel.Humiditiy = weatherResponse.Main.Humaditiy;
                viewModel.Pressure = weatherResponse.Main.pressure;
                viewModel.Weather = weatherResponse.Weather[0].Main;
                viewModel.Wind = weatherResponse.Wind.Speed;
                
            }
            return View(viewModel);
        }
    }
}
