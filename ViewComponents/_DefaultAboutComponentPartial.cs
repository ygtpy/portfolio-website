using Microsoft.AspNetCore.Mvc;
using AkademiQPortfolio.Data;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        public readonly AppDbContext _context;

        public _DefaultAboutComponentPartial(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var aboutList =_context.Abouts.ToList();
            return View(aboutList);
        }


    }
}
