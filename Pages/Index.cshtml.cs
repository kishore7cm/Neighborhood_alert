using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NeighbourhoodCrime;
using NeighbourhoodLocation;

namespace Neighbourhood_Alert.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                String neighbourhoodjsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/rvmt-pkmq.json");
                var neighbourhoodlocations = Neighbourhood.FromJson(neighbourhoodjsonString);
                ViewData["neighbourhood"] = neighbourhoodlocations;



                String crimejsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/vnsz-a3wp.json");
                var crimes = Crime.FromJson(crimejsonString);
                ViewData["crimes"] = crimes;
            }
        }
    }
}
