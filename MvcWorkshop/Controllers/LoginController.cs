using Microsoft.AspNetCore.Mvc;

namespace MvcWorkshop.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
