using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Core_ProjeDb.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;


            //Hava Durumu Apisi
            string api = "79dbc22f9cfe41e1db0958e0eef87f8e";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=%C4%B0stanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;



            //İstatistikler 
            Context c = new Context();
            ViewBag.v1 = c.writerMessages.Where(x=>x.Receiver==values.Email).Count();
            ViewBag.v2 = c.announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.skills.Count();
            return View();
        }
    }
}
/*
 https://api.openweathermap.org/data/2.5/weather?q=%C4%B0stanbul&mode=xml&lang=tr&units=metric&appid=db5e1a2f70b0b46f2cc463de99efef9f
 */
