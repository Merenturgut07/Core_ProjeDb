using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeDb.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult DefaultHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult DefaultNavbarPartial()
        {
            return PartialView();
        }


        [HttpGet]
        public PartialViewResult DefaultContactSendMessagePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult DefaultContactSendMessagePartial(Message p)
        {
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            messageManager.TAdd(p);
            return PartialView();
        }
    }
}
