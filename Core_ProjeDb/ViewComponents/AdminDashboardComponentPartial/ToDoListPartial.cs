using BussinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeDb.ViewComponents.AdminDashboardComponentPartial
{
    public class ToDoListPartial:ViewComponent
    {
        ToDoListManager toDoListManager=new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.TGetList();
            return View(values);
        }
    }
}
