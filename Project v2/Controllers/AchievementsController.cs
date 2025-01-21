using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_v2.Data;
using Project_v2.Models;

namespace Project_v2.Controllers
{
    public class AchievementsController : Controller
    {
        private readonly ApplicationContext _context;

        public AchievementsController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var achievements = _context.Achievements.ToList();
            return View(achievements);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Achievements achievement)
        {
            if (ModelState.IsValid)
            {
                
                var playerExists = _context.Players.Any(p => p.id == achievement.playerid);
                if (!playerExists)
                {
                    ModelState.AddModelError("playerid", "Указанный игрок не существует.");
                }

                
                var teamExists = _context.Teams.Any(t => t.id == achievement.teamid);
                if (!teamExists)
                {
                    ModelState.AddModelError("teamid", "Указанная команда не существует.");
                }

                
                if (!playerExists || !teamExists)
                {
                    return View(achievement);
                }

               
                _context.Achievements.Add(achievement);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(achievement);
        }

        
        public IActionResult Delete(int id)
        {
            var achievement = _context.Achievements.FirstOrDefault(a => a.id == id);
            return View(achievement);  
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var achievement = _context.Achievements.Find(id);

            
                _context.Achievements.Remove(achievement);  
                _context.SaveChanges();  
            

            return RedirectToAction("Index");  
        }

        public IActionResult EditGet(int? id)
        {
            var achievement = _context.Achievements.Find(id);
            return View(achievement);  
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPost(int id, Achievements achievement)
        {
           
            if (ModelState.IsValid)
            {
                
                var playerExists = _context.Players.Any(p => p.id == achievement.playerid);
                if (!playerExists)
                {
                    ModelState.AddModelError("playerid", "Такого ID игрока не существует.");
                }

                var teamExists = _context.Teams.Any(t => t.id == achievement.teamid);
                if (!teamExists)
                {
                    ModelState.AddModelError("teamid", "Такого ID команды не существует.");
                }

                if (!playerExists || !teamExists)
                {
                    return View(achievement);
                }

                _context.Update(achievement);  
                _context.SaveChanges();  
                return RedirectToAction("Index");  
            }
            return View(achievement);  
        }
    }
}
