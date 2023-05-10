using Microsoft.AspNetCore.Mvc;

namespace MVCDemoApp.Controllers
{
    public class EmployeeController : Controller
    {
        public string Display()
        {
            return "Hello MVC Core";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
