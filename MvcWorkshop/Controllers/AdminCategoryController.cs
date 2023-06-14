using Microsoft.AspNetCore.Mvc;

namespace MvcWorkshop.Controllers
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
