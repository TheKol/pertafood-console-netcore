using Microsoft.AspNetCore.Mvc;

namespace console.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}