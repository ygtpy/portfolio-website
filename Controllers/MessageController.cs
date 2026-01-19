using Microsoft.AspNetCore.Mvc;
using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using System.Linq;

namespace AkademiQPortfolio.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Messages.OrderByDescending(x => x.SendDate).ToList();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MessageDetails(int id)
        {
            var value = _context.Messages.Find(id);
            if (value != null && value.IsRead == false)
            {
                 value.IsRead = true;
                 _context.SaveChanges(); // Mark as read when opened
            }
            return Json(value);
        }
    }
}
