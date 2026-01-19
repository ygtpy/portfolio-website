using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultPortfolioComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultPortfolioComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Works.ToList();
            return View(values);
        }
    }
}
