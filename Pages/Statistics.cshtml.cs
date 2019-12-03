using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NeighborhoodCrime;
using Traffic;

namespace Neighbourhood_Alert.Pages
{
    public class StatisticsModel : PageModel
    {
        public string Search { get; set; }
        public bool SearchCompleted { get; set; }
        public ICollection<TrafficAccident> trafficAccidents { get; set; }
        public ICollection<Crime> crimes { get; set; }


        HashSet<string> locationNames = new HashSet<string>();

        public StatisticsModel()
        {
            using (var webClient = new WebClient())
            {

                String trafficjsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/rvmt-pkmq.json");
                trafficAccidents = TrafficAccident.FromJson(trafficjsonString);

                String crimejsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/k59e-2pvf.json");
                crimes = Crime.FromJson(crimejsonString);
            }

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

        public void OnGet()
        {
            SearchCompleted = false;
            foreach ( Traffic.TrafficAccident traffic in trafficAccidents)
            {
                if (!traffic.CommunityCouncilNeighborhood.Equals("N/A"))
                {
                    locationNames.Add(traffic.CommunityCouncilNeighborhood.ToUpper());
                }
            }

            foreach (NeighborhoodCrime.Crime crime in crimes)
            {
                if (!crime.CommunityCouncilNeighborhood.Equals("N/A"))
                {
                    locationNames.Add(crime.CommunityCouncilNeighborhood.ToUpper());
                }
            }

            ViewData["LocationNames"] = locationNames;
            ViewData["trafficAccidents"] = trafficAccidents;
            ViewData["crimes"] = crimes;
        }
    }
}