using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateUser());
        }

        public User CreateUser()
        {
            User user = new User()
            {
                Name = "ASP.NET 5 Developer on a MAC :)",
                Address = "Mac land and the Cloud"
            };

            return user;
        }
    }
}