using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWorkshop.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mc = new MessageManager(new EfMessageDal());
        public IActionResult Inbox()
        {
            var messageList = mc.GetListInbox();
            return View(messageList);
        }
        public ActionResult SendBox()
        {
            var messageList = mc.GetListSendbox();
            return View(messageList);
        }
    }
}
