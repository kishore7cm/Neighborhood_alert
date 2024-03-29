#pragma checksum "D:\MSIS\XML Webservices\Final_project\Neighborhood_alert\Pages\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "861f24a6f3bd01bfe1713b5d161cec6a37a61435"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Neighbourhood_Alert.Pages.Pages_Statistics), @"mvc.1.0.razor-page", @"/Pages/Statistics.cshtml")]
namespace Neighbourhood_Alert.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\MSIS\XML Webservices\Final_project\Neighborhood_alert\Pages\_ViewImports.cshtml"
using Neighbourhood_Alert;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861f24a6f3bd01bfe1713b5d161cec6a37a61435", @"/Pages/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf7dabe5b335ea200ee42707c189b4df652da91", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Statistics : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\MSIS\XML Webservices\Final_project\Neighborhood_alert\Pages\Statistics.cshtml"
  
    ViewData["Title"] = "Statistics";
    var locationNames = ViewData["LocationNames"];
    var trafficAccidents = (Traffic.TrafficAccident[])ViewData["trafficAccidents"];
    var crimes = (NeighborhoodCrime.Crime[])ViewData["crimes"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<center><h1>Breakdown of Road Accidents and Crimes in each Neighborhood</h1></center>
<h5 align=""center""><strong>Cincinnati Neighborhood Alert Statistics</strong></h5>
<table class=""table table-bordered table-light table-striped"">
    <thead>
        <tr>
            <th>Neighborhood</th>
            <th>Road Accidents</th>
            <th>Crime</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "D:\MSIS\XML Webservices\Final_project\Neighborhood_alert\Pages\Statistics.cshtml"
         foreach (var neighborhood in ViewBag.locationNames)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "D:\MSIS\XML Webservices\Final_project\Neighborhood_alert\Pages\Statistics.cshtml"
               Write(neighborhood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\MSIS\XML Webservices\Final_project\Neighborhood_alert\Pages\Statistics.cshtml"
               Write(trafficAccidents.Where(x => x.CommunityCouncilNeighborhood.ToUpper().Equals(neighborhood.ToUpper())).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\MSIS\XML Webservices\Final_project\Neighborhood_alert\Pages\Statistics.cshtml"
               Write(crimes.Where(x => x.CommunityCouncilNeighborhood.ToUpper().Equals(neighborhood.ToUpper())).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "D:\MSIS\XML Webservices\Final_project\Neighborhood_alert\Pages\Statistics.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Neighbourhood_Alert.Pages.StatisticsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Neighbourhood_Alert.Pages.StatisticsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Neighbourhood_Alert.Pages.StatisticsModel>)PageContext?.ViewData;
        public Neighbourhood_Alert.Pages.StatisticsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
