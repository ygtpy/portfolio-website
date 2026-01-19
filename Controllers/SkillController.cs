using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var skill = _context.Skills.Find(id);

            if (skill == null)
            {
                return NotFound();
            }

            _context.Skills.Remove(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var skill = _context.Skills.Find(id);

            if (skill == null)
            {
                return NotFound();
            }
            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult UpdateSkill(Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }

            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
