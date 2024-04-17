using Microsoft.AspNetCore.Mvc;

namespace MyStaticApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, World!");
        }
    }
}
