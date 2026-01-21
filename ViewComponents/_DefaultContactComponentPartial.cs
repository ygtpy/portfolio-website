using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        public readonly AppDbContext _context;

        public _DefaultContactComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var contactList = _context.Contacts.ToList();
            return View(contactList);
        }
    }
}
