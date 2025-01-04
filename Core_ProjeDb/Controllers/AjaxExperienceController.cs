using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_ProjeDb.Controllers
{
    public class AjaxExperienceController : Controller
    {
        ExperienceManager experienceManager=new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult GetById(int ExperienceId)
        {
            var v=experienceManager.TGetById(ExperienceId);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetById(id);
            experienceManager.TDelete(v);
            return NoContent();
        }


        public IActionResult UpdateExperience(Experience p)

        {

            var values = experienceManager.TGetById(p.ExperienceId);

            values.Name = p.Name;

            values.ImageUrl = p.ImageUrl;

            values.Date = p.Date;

            values.Description = p.Description;

            experienceManager.TUpdate(values);

            var v = JsonConvert.SerializeObject(values);

            return Json(v);

        }

    }
}
