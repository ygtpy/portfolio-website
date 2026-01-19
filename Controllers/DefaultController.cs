using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AkademiQPortfolio.Data.AppDbContext _context;

        public DefaultController(AkademiQPortfolio.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(AkademiQPortfolio.Entities.Message message)
        {
            if (ModelState.IsValid)
            {
                message.SendDate = System.DateTime.Now;
                message.IsRead = false;
                _context.Messages.Add(message);
                _context.SaveChanges();
                return RedirectToAction("Index"); // Or show success message
            }
            return RedirectToAction("Index");
        }
    }
}
