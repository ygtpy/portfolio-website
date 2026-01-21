using AkademiQPortfolio.Entities;
using System.Linq;

namespace AkademiQPortfolio.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any existing data.
            if (context.Abouts.Any())
            {
                return;   // DB has been seeded
            }

            // About
            var abouts = new About[]
            {
                new About
                {
                    NameSurname = "Yiğit Ali Sunal",
                    Title1 = "Full Stack Developer",
                    Title2 = "Software Engineer",
                    Title3 = "Tech Enthusiast",
                    Description = "Modern web teknolojileri ve yazılım geliştirme konusunda tutkulu bir geliştiriciyim. .NET ekosistemi üzerinde uzmanlaşarak, kullanıcı dostu ve performanslı uygulamalar geliştiriyorum.",
                    Phone = "+90 555 555 5555",
                    Email = "yigitali@example.com",
                    Address = "İstanbul, Türkiye",
                    ImageUrl = "https://via.placeholder.com/300"
                }
            };
            foreach (var a in abouts)
            {
                context.Abouts.Add(a);
            }

            // Experience
            var experiences = new Experience[]
            {
                new Experience
                {
                    CompanyName = "Tech Solutions Ltd.",
                    Title = "Junior Software Developer",
                    WorkDate = "2023 - Günümüz",
                    Desription = "ASP.NET Core ve React kullanarak kurumsal web uygulamaları geliştirme.",
                    IconUrl = "briefcase"
                },
                new Experience
                {
                    CompanyName = "Creative Digital Agency",
                    Title = "Stajyer Yazılımcı",
                    WorkDate = "2022 - 2023",
                    Desription = "Frontend geliştirme ve UI/UX tasarımı üzerine çalışmalar.",
                    IconUrl = "code-working"
                }
            };
            foreach (var e in experiences)
            {
                context.Experiences.Add(e);
            }

            // Education
            var educations = new Education[]
            {
                new Education
                {
                    Title = "Bilgisayar Programcılığı",
                    Department = "Bilgisayar Programcılığı",
                    EducationDate = "2021 - 2024"
                },
                new Education
                {
                    Title = "İzzettin Çalılşar Anadolu Lisesi",
                    Department = "Sayısal Bölüm",
                    EducationDate = "2016 - 2020"
                }
            };
            foreach (var e in educations)
            {
                context.Educations.Add(e);
            }

            // Skills
            var skills = new Skill[]
            {
                new Skill { SkillTitle = "C#", SkillValue = 90, Knowledge = "Advanced", Language = "C#" },
                new Skill { SkillTitle = "ASP.NET Core", SkillValue = 85, Knowledge = "Advanced", Language = "C#" },
                new Skill { SkillTitle = "SQL Server", SkillValue = 80, Knowledge = "Intermediate", Language = "SQL" },
                new Skill { SkillTitle = "HTML/CSS", SkillValue = 95, Knowledge = "Advanced", Language = "Web" },
                new Skill { SkillTitle = "JavaScript", SkillValue = 75, Knowledge = "Intermediate", Language = "JS" },
                new Skill { SkillTitle = "Git", SkillValue = 85, Knowledge = "Intermediate", Language = "Tools" }
            };
            foreach (var s in skills)
            {
                context.Skills.Add(s);
            }

            context.SaveChanges();
        }
    }
}
