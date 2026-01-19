using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AkademiQPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _context;

        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            if(value != null)
            {
                _context.Experiences.Remove(value);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
