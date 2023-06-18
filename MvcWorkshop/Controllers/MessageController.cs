using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWorkshop.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mc = new MessageManager(new EfMessageDal());
        MessageValidator validationRules = new MessageValidator();
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

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            return View();
        }
    }
}
