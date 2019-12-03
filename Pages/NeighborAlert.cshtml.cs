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
    public class NeighborAlertModel : PageModel
    {
        public ICollection<TrafficAccident> trafficAccidents { get; set; }
        public ICollection<Crime> crimes { get; set; }

        HashSet<string> locationNames = new HashSet<string>();
        public void OnGet()
        {
            String trafficjsonString = GetData("https://data.cincinnati-oh.gov/resource/rvmt-pkmq.json");
            trafficAccidents = TrafficAccident.FromJson(trafficjsonString);                   


            string crimejsonString = GetData("https://data.cincinnati-oh.gov/resource/k59e-2pvf.json");
            crimes = Crime.FromJson(crimejsonString);            

            //foreach (Traffic.TrafficAccident traffic in trafficAccidents)
            //{
            //    if (!traffic.CommunityCouncilNeighborhood.Equals("N/A"))
            //    {
            //        locationNames.Add(traffic.CommunityCouncilNeighborhood.ToUpper());
            //    }
            //}

            foreach (Crime crime in crimes)
            {
                if (!crime.CommunityCouncilNeighborhood.Equals("N/A"))
                {
                    locationNames.Add(crime.CommunityCouncilNeighborhood.ToUpper());
                }
            }

            ViewData["LocationNames"] = locationNames;

        }
        public void OnPost()
        {
            //ViewData["LocationNames"] = locationNames;

            //crimes = crimes.Where(x => x.CommunityCouncilNeighborhood.ToUpper().Equals(Search.ToUpper())).ToArray();
            //ViewData["crimes"] = crimes;
           
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