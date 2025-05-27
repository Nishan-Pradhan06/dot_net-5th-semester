using Microsoft.AspNetCore.Mvc;
using TestWebAppDotNet.Models;

namespace TestWebAppDotNet.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> list = new List<Student>()
            {
                new Student(){Id = 101, Name="Nishan", Address ="Belbari", JoinDate=new DateOnly(2025,2,19)}
            };
            return View(list);
        }
    }
}
