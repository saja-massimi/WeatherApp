using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Controllers
{
    public class UserController : Controller
    {
     readonly Entities.UsersContext obj = new Entities.UsersContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUser(Models.UserModel userModel)
        {

            WeatherApp.Entities.User u = new WeatherApp.Entities.User();

            u.Username = userModel.username;
            u.Password = userModel.password;
            u.Email = userModel.email;

            obj.Users.Add(u);
            obj.SaveChanges();

            return RedirectToAction("ViewUsers");

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
