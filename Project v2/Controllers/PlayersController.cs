using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Project_v2.Data;
using Project_v2.Models;

namespace Project_v2.Controllers
{
    public class PlayersController:Controller
    {
        private readonly ApplicationContext _context;

        public PlayersController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var players = _context.Players.ToList();

            if (players == null || !players.Any())
            {
                
                Console.WriteLine("Игроков в базе данных нет");
                return View("Error");  
            }

            return View(players);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (Players player)
        {
            if (ModelState.IsValid)
            {
                _context.Players.Add(player);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Delete(int id)
        {
            var player = _context.Players.FirstOrDefault(p => p.id == id);
            return View(player);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var player = _context.Players.Find(id);
            if (player != null)
            {
                _context.Players.Remove(player);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var player = _context.Players.Find(id);
            return View(player);  
        }

        
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult EditPost(int id, Players player)
        {
            
            if (ModelState.IsValid)
            {
                _context.Update(player);
                _context.SaveChanges();
                return RedirectToAction("Index");  
            }
            return View(player);  
        }
    }
}
