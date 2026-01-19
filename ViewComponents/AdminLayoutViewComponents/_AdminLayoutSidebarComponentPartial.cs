using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AkademiQPortfolio.Data;

namespace AkademiQPortfolio.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSidebarComponentPartial: ViewComponent
    {
        private readonly AkademiQPortfolio.Data.AppDbContext _context;

        public _AdminLayoutSidebarComponentPartial(AkademiQPortfolio.Data.AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.UnreadMessageCount = _context.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
