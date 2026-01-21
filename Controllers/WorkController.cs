using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult WorkList()
        {
            var values = _context.Works.ToList();
            return View(values);
        }

        [HttpGet]

        public IActionResult CreateWork()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateWork(Work work)
        {
            _context.Works.Add(work);
            _context.SaveChanges();
            return RedirectToAction("WorkList");
        }

        public IActionResult DeleteWork(int id)
        {
            var values = _context.Works.Find(id);
            _context.Works.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("WorkList");
        }


        [HttpGet]

        public IActionResult UpdateWork(int id)
        {
            var value = _context.Works.Find(id);
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateWork(Work work)
        {
            _context.Works.Update(work);
            _context.SaveChanges();
            return RedirectToAction("WorkList");
        }

    }
}
