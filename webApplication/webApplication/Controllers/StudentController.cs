using Microsoft.AspNetCore.Mvc;
using webApplication.Models;

namespace webApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Display()
        {
            return View(new List<Student>());
        }


        [HttpPost]
        public IActionResult Display(Student student)
        {
            List<Student> list = new List<Student>();
            list.Add(student);
            return View(list);
        }

    }
}
