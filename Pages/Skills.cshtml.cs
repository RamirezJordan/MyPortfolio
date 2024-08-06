using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MyPortfolio.Pages
{
    public class SkillsModel : PageModel
    {
        public List<string> TechnicalSkills { get; set; }
        public List<string> ProfessionalSkills { get; set; }

        public void OnGet()
        {
            TechnicalSkills = new List<string>
            {
                "C#",
                ".NET Core",
                "ASP.NET",
                "JavaScript",
                "SQL",
                "HTML & CSS"
            };

            ProfessionalSkills = new List<string>
            {
                "Problem-solving",
                "Teamwork",
                "Time management",
                "Communication",
                "Adaptability"
            };
        }
    }
}