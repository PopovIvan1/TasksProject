using Microsoft.AspNetCore.Mvc;

namespace TasksProject.Server.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
    }
}