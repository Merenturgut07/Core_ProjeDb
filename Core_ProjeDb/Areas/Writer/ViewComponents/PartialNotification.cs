using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeDb.Areas.Writer.ViewComponents
{
    public class PartialNotification:ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
       
        public IViewComponentResult Invoke()
        {
            var values=announcementManager.TGetList().Take(4).ToList();
            return View(values);
        }
    }
}
