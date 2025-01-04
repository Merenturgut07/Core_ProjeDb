using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeDb.ViewComponents.AdminDashboardComponentPartial
{
    public class StatisticsDashboard2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.portfolios.Count();
            ViewBag.v2 = c.messages.Count();
            ViewBag.v3 = c.services.Count();
            return View();
        }
    }
}
