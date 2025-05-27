using Microsoft.AspNetCore.Mvc;

namespace TestWebAppDotNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Next()
        {
            return View();
        }
    }
}
