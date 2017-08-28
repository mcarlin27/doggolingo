using Microsoft.AspNetCore.Mvc;

namespace Doggolingo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
