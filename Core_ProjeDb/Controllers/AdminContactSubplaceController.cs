using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeDb.Controllers
{
    public class AdminContactSubplaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateContactSubplace(int id)
        {
            var values = contactManager.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContactSubplace(Contact contact)
        {
            contactManager.TUpdate(contact);
            return RedirectToAction("Index", "Default");
        }


    }
}
