#pragma checksum "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62acd0f0af9e767f09c02fb383c39d70fb606325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Neighbourhood_Alert.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 1 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\_ViewImports.cshtml"
using Neighbourhood_Alert;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62acd0f0af9e767f09c02fb383c39d70fb606325", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf7dabe5b335ea200ee42707c189b4df652da91", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    //var name = ViewData["MyName"];
    //var age = ViewData["age"];
    //IList<NeighborhoodLocation.Neighborhood> NeighborhoodList;
    //var NeighborhoodList = ViewData["neighbourhood"] as IList<NeighborhoodLocation.Attributes>;
    IList<NeighborhoodCrime.Crime> NeighborhoodCrimeList = (IList<NeighborhoodCrime.Crime>)ViewData["crimes"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <table>
        <tr>
            <th>Incident Number</th>
            <th>Date Reported</th>
            <th>Offense</th>
            <th>Weapons</th>
            <th>Cpd_neighborhood</th>
            <th>Address</th>            
        </tr>
");
#nullable restore
#line 24 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
             foreach (NeighborhoodCrime.Crime Crimes in NeighborhoodCrimeList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 27 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
                           Write(Crimes.IncidentNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
                           Write(Crimes.DateReported);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
                           Write(Crimes.Offense);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
                           Write(Crimes.Weapons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
                           Write(Crimes.Neighborhood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
                           Write(Crimes.AddressX);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "D:\MSIS\XML Webservices\Neighborhood_alert\Pages\Index.cshtml"
                    
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <br />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
