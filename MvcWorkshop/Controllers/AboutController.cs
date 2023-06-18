using Microsoft.AspNetCore.Mvc;

namespace MvcWorkshop.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
