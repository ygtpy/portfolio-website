using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace AkademiQPortfolio.Controllers
{
    public class StatisticsController : Controller
    {
        public readonly AppDbContext _context;

        public StatisticsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult StatisticsCards()
        {   var messageCount = _context.Messages.Count();
            var messageCountByIsReadTrue = _context.Messages.Where(x => x.IsRead == true).Count();
            var messageCountByIsReadFalse = _context.Messages.Where(x => x.IsRead == false).Count();
            var skillCount = _context.Messages.Count();
            var skillAvgValue = _context.Skills.Average(x => x.SkillValue); 
            var skillValueBiggerThan1 = _context.Skills.Where(x => x.SkillValue >= 1).Count();
                                

            ViewBag.MessageCount = messageCount;
            ViewBag.MessageCountByIsReadTrue = messageCountByIsReadTrue;
            ViewBag.MessageCountByIsReadFalse = messageCountByIsReadFalse;
            ViewBag.SkillCount = skillCount;
            ViewBag.SkillAvgValue = skillAvgValue;
            ViewBag.SkillValueBiggerThan1 = skillValueBiggerThan1;

            var messageSubjectByWorkOffer = _context.Messages.Where(x => x.MessageSubject == "Proje Teklifi & İş Birliği").Count();
            var messageSubjectByApiDevelopment = _context.Messages.Where(x => x.MessageSubject == "Web / API Geliştirme Talebi").Count();
            var messageSubjectByEducationOffer = _context.Messages.Where(x => x.MessageSubject == "Eğitim & Kurumsal Eğitim Talebi\r\n").Count();

            ViewBag.MessageSubjectByWorkOffer = messageSubjectByWorkOffer;
            ViewBag.MessageSubjectByApiDevelopment = messageSubjectByApiDevelopment;
            ViewBag.MessageSubjectByEducationOffer = messageSubjectByEducationOffer;

            return View();
        }
    }
}
