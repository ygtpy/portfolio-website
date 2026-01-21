using AkademiQPortfolio.Data;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly AppDbContext _context;

        public StatisticsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult StatisticsCards()
        {
            var messageCount = _context.Messages.Count();
            var messageCountByIsReadTrue = _context.Messages.Where(x => x.isRead == true).Count();
            var messageCountByIsReadFalse = _context.Messages.Where(x => x.isRead == false).Count();
            var skillCount = _context.Skills.Count();
            var skillAvgValue = _context.Skills.Average(x => x.SkillValue);
            var skillValueGreaterThan70 = _context.Skills.Where(x => x.SkillValue >= 70).Count();

            ViewBag.MessageCount = messageCount;
            ViewBag.SkillCount = skillCount;
            ViewBag.MessageCountByIsReadTrue = messageCountByIsReadTrue;
            ViewBag.MessageCountByIsReadFalse = messageCountByIsReadFalse;
            ViewBag.SkillAvgValue = skillAvgValue;
            ViewBag.SkillValueGreaterThan70 = skillValueGreaterThan70;

            var messageSubjectByWorkOffer = _context.Messages.Where(x => x.messageSubject == "İş teklifi").Count();
            var messageSubjectByInternship = _context.Messages.Where(x => x.messageSubject == "Staj başvurusu").Count();
            var messageSubjectByInvitationtoInterview = _context.Messages.Where(x => x.messageSubject == "Mülakata davet").Count();
            var messageSubjectByFreelanceProject = _context.Messages.Where(x => x.messageSubject == "Freelance proje").Count();

            ViewBag.MessageSubjectByWorkOffer = messageSubjectByWorkOffer;
            ViewBag.MessageSubjectByInternship = messageSubjectByInternship;
            ViewBag.MessageSubjectByInvitationtoInterview = messageSubjectByInvitationtoInterview;
            ViewBag.MessageSubjectByFreelanceProject = messageSubjectByFreelanceProject;

            return View();
        }
    }
}
