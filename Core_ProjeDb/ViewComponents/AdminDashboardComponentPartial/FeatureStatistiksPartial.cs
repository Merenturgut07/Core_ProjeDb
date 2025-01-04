using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeDb.ViewComponents.AdminDashboardComponentPartial
{
    public class FeatureStatistiksPartial:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.skills.Count();
            ViewBag.v2 = c.messages.Where(x => x.Status == false).Count();
            ViewBag.v3 = c.messages.Where(x => x.Status == true).Count();
            ViewBag.v4 = c.experiences.Count();
            return View();
        }
    }
}
