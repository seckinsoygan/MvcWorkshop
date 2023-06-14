using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWorkshop.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            var WriterValues = wm.GetAll();
            return View(WriterValues);
        }
    }
}
