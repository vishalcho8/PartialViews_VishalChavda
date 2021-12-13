using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartialViews_VishalChavda.Models;

namespace PartialViews_VishalChavda.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //public Films Films { get; set; }

        public List<Films> Films { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Films = new List<Films>();
            Films.Add(new Films() { Title = "Nomadland", Description = "A woman in her sixties who, after losing everything in the Great Recession, embarks on a journey through the American West, living as a van-dwelling modern-day nomad.", Duration = "3 hours" });
            Films.Add(new Films() { Title = "Annabelle", Description = "Annabelle is a 2014 American supernatural horror film directed by John R. Leonetti, written by Gary Dauberman and produced by Peter Safran and James Wan.", Duration = "2 hours" });
            Films.Add(new Films() { Title = "The Godfather", Description = "The Godfather is set in the 1940s and takes place entirely within the world of the Corleones, a fictional New York Mafia family. It opens inside the dark office of the family patriarch, Don Vito Corleone (also known as the Godfather and played by Brando), on the wedding day of his daughter, Connie (Talia Shire).", Duration = "2.5 hours" });
            Films.Add(new Films() { Title = "Cliff Walkers", Description = "Trained in the Soviet Union, four special agents find themselves in constant danger after a traitor sells them out.", Duration = "3 hours" });
        }
    }
}
