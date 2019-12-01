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
            List<Crime> Crimes = new List<Crime>();


            // string neighborhood = GetData("https://cagisonline.hamilton-co.org/arcgis/rest/services/CINC_PLANNING/Munitwps_Neighborhoods/MapServer/1/query?where=1%3D1&outFields=OBJECTID,CAGIS.Cinc_Community_Council_Bnd.AREA,PERIMETER,NEIGH_BND_,NEIGH,LINE,ACRES,NEIGH_BOUN,REVISED_DA&returnGeometry=false&outSR=4326&f=json");

            string neighbourhoodjsonString = GetData("https://cagisonline.hamilton-co.org/arcgis/rest/services/CINC_PLANNING/Munitwps_Neighborhoods/MapServer/1/query?where=1%3D1&outFields=OBJECTID,CAGIS.Cinc_Community_Council_Bnd.AREA,PERIMETER,NEIGH_BND_,NEIGH,LINE,ACRES,NEIGH_BOUN,REVISED_DA&returnGeometry=false&outSR=4326&f=json");
            Neighborhood[] neighbourhoodlocations = Neighborhood.FromJson(neighbourhoodjsonString);
            ViewData["neighbourhood"] = neighbourhoodlocations;

            string crimejsonString = GetData("https://data.cincinnati-oh.gov/resource/k59e-2pvf.json");
            Crime[] crimes = Crime.FromJson(crimejsonString);
            ViewData["crimes"] = crimes;


            IDictionary<string, Neighborhood> Neighborhd = new Dictionary<string, Neighborhood>();

            foreach (Neighborhood Neibor in neighbourhoodlocations)
            {

                Neighborhd.Add(Neibor.FieldAliases.Objectid, Neibor);
            }
            DateTime dt = DateTime.Parse("11/01/2019");
            foreach (Crime crime in crimes)
            {
                foreach (var Neigh in Neighborhd)
                {
                    if (crime.Neighborhood == Neigh.Value.FieldAliases.Neigh && crime.DateReported.DateTime > dt)
                    {
                        Crimes.Add(crime);
                    }
                }
            }
            ViewData["Neighborhoodcrimes"] = Crimes;
        }

        public string GetData(string endpoint)
        {
            string downloadedJson = "";
            using (WebClient webClient = new WebClient())
            {
                downloadedJson = webClient.DownloadString(endpoint); ;
            }
            return downloadedJson;
        }
    }

}
