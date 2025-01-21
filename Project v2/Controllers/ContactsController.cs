using Microsoft.AspNetCore.Mvc;
using Project_v2.Models;

namespace Project_v2.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Метод принимает данные из формы
        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if (ModelState.IsValid) 
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
