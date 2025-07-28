using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace todo.Controllers
{
    public class HomeController : Controller
    {
        private static List<Todo> todos = new();
        private static int idCounter = 1;


        [HttpGet]
        public IActionResult Index()
        {
            return View(todos);
        }

        [HttpPost]
        public IActionResult Add(string title)
        {
           todos.Add(new Todo { Id = idCounter++, Title = title, IsCompleted = false });
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Toggle(int id)   

        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
                todo.IsCompleted = !todo.IsCompleted;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
                todos.Remove(todo);

            return RedirectToAction("Index");
        }
    }
}
