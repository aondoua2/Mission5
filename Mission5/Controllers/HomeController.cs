using Microsoft.AspNetCore.Mvc;

namespace Mission5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Service()
        {
            // write our code here
            return View("Service");
        }
    }
}
