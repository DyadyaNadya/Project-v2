using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_v2.Data;
using Project_v2.Models;

namespace Project_v2.Controllers
{
    public class TeamsController : Controller
    {

        private readonly ApplicationContext _context;

        public TeamsController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var teams = _context.Teams.ToList();
            return View(teams);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teams team)
        {
            if (ModelState.IsValid)
            {
                _context.Teams.Add(team);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(team);
        }

        public IActionResult Delete(int id)
        {
            var team = _context.Teams.FirstOrDefault(t => t.id == id);
            return View(team);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var team = _context.Teams.Find(id);
            _context.Teams.Remove(team);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var team = _context.Teams.Find(id);
            return View(team);  
        }

        
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult EditPost(int id, Teams team)
        {
            if (ModelState.IsValid)
            {
                _context.Update(team);  
                _context.SaveChanges();  
                return RedirectToAction("Index");  
            }
            return View(team);  
        }
    }
}
