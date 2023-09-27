using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {

        Entities.UsersContext obj = new Entities.UsersContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddUser(Models.UserModel userModel)
        {

            WeatherApp.Entities.User u = new WeatherApp.Entities.User();

            u.Username = userModel.username;
            u.Password = userModel.password;
            u.Email = userModel.email;

            obj.Users.Add(u);
            obj.SaveChanges();

            return View();

        }
        public IActionResult ViewUsers()
        {
            List<Models.UserModel> lstData = new List<Models.UserModel>();

            lstData = (from o in obj.Users.ToList()
                       select new Models.UserModel
                       {
                           User_ID = o.UserId,
                           username = o.Username,
                           email = o.Email,
                           password = o.Password,
                       }).ToList();

            return View(lstData);
        }
    }
}
