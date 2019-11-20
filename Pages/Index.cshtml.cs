using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Neighbourhood;
using NeighbourhoodCrime;

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
                String crimesDetailsJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/k59e-2pvf.json");
                var crimes = Crime.FromJson(crimesDetailsJsonString);
                ViewData["crimes"] = crimes;

                String neighbourhoodjsonString = webClient.DownloadString("https://cagisonline.hamilton-co.org/arcgis/rest/services/CINC_PLANNING/Munitwps_Neighborhoods/MapServer/1/query?where=1%3D1&outFields=*&outSR=4326&f=json");
                var neighbourhoods = NeighbourhoodAlert.FromJson(neighbourhoodjsonString);
                ViewData["neighbourhoods"] = neighbourhoods;

            }
        }
    }
}
