using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NeighborhoodLocation;
using NeighborhoodCrime;

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
            IList<Neighborhood> NeighborhoodList = new List<Neighborhood>();
            IList<Crime> NeighborhoodCrimeList = new List<Crime>();

            using (var webClient = new WebClient())
            {
                // string neighborhood = GetData("https://cagisonline.hamilton-co.org/arcgis/rest/services/CINC_PLANNING/Munitwps_Neighborhoods/MapServer/1/query?where=1%3D1&outFields=OBJECTID,CAGIS.Cinc_Community_Council_Bnd.AREA,PERIMETER,NEIGH_BND_,NEIGH,LINE,ACRES,NEIGH_BOUN,REVISED_DA&returnGeometry=false&outSR=4326&f=json");
                string neighbourhoodjsonString = "";
                neighbourhoodjsonString = webClient.DownloadString("https://cagisonline.hamilton-co.org/arcgis/rest/services/CINC_PLANNING/Munitwps_Neighborhoods/MapServer/1/query?where=1%3D1&outFields=OBJECTID,CAGIS.Cinc_Community_Council_Bnd.AREA,PERIMETER,NEIGH_BND_,NEIGH,LINE,ACRES,NEIGH_BOUN,REVISED_DA&returnGeometry=false&outSR=4326&f=json");
                var neighbourhoodlocations = Neighborhood.FromJson(neighbourhoodjsonString);
                ViewData["neighbourhood"] = neighbourhoodlocations;

                string crimejsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/k59e-2pvf.json");
                var crimes = Crime.FromJson(crimejsonString);
                ViewData["crimes"] = crimes;
            }
        }
    }
}
