using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AkademiQPortfolio.Data;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultContactComponentPartial: ViewComponent
    {
        private readonly AkademiQPortfolio.Data.AppDbContext _context;

        public _DefaultContactComponentPartial(AkademiQPortfolio.Data.AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Contacts.ToList();
            return View(values);
        }
    }
}
