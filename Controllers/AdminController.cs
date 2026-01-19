using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AkademiQPortfolio.Controllers
{
    public class AdminController : Controller
    {
        private readonly AkademiQPortfolio.Data.AppDbContext _context;

        public AdminController(AkademiQPortfolio.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = _context.Skills.Count();
            ViewBag.v2 = _context.Messages.Count();
            ViewBag.v3 = _context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = _context.Works.Count();
            ViewBag.v5 = _context.Testimonials.Count();
            ViewBag.v6 = _context.Experiences.Count();
            return View();
        }
    }
}
