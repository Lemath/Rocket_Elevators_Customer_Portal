#pragma checksum "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7bd48f61359cce2390400cdbd586b9cd3c80830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Battery_Index), @"mvc.1.0.view", @"/Views/Battery/Index.cshtml")]
namespace AspNetCore
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
#line 1 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bd48f61359cce2390400cdbd586b9cd3c80830", @"/Views/Battery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43fdba9ec3567df5250e21f4feb7b14e91ed237", @"/Views/_ViewImports.cshtml")]
    public class Views_Battery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
  
    ViewData["Title"] = "Battery";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center"">Your Batteries</h2>
<div class=""table-responsive"">
  <table class=""table table-striped text-center"">
    <thead class=""thead-dark"">
      <tr>
        <th scope=""col"">ID</th>
        <th scope=""col"">Building</th>
        <th scope=""col"">Status</th>
        <th scope=""col"">Employee</th>
        <th scope=""col"">Operation Certificate</th>
        <th scope=""col"">Information</th>
        <th scope=""col"">Notes</th>
      </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
     foreach (var battery in ViewBag.Batteries)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\n        <td>");
#nullable restore
#line 23 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
       Write(battery.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 24 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
       Write(battery.building_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 25 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
       Write(battery.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 26 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
       Write(battery.employee_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 27 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
       Write(battery.Operation_Certificate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 28 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
       Write(battery.Information);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 29 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
       Write(battery.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      </tr>\n");
#nullable restore
#line 31 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Battery/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n  </table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
