#pragma checksum "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7338763b3fb529c8c86f8802bcfb95d185ee4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Column_Index), @"mvc.1.0.view", @"/Views/Column/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7338763b3fb529c8c86f8802bcfb95d185ee4c", @"/Views/Column/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43fdba9ec3567df5250e21f4feb7b14e91ed237", @"/Views/_ViewImports.cshtml")]
    public class Views_Column_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
  
    ViewData["Title"] = "Column";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""text-center"">Your Columns</h2>
<div class=""table-responsive"">
  <table class=""table table-striped text-center"">
    <thead class=""thead-dark"">
      <tr>
        <th scope=""col"">ID</th>
        <th scope=""col"">Battery ID</th>
        <th scope=""col"">Status</th>
        <th scope=""col"">Type of Building</th>
        <th scope=""col"">Number of Floor Served</th>
        <th scope=""col"">Information</th>
        <th scope=""col"">Notes</th>
      </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
     foreach (var column in ViewBag.Columns)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\n        <td>");
#nullable restore
#line 22 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
       Write(column.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 23 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
       Write(column.battery_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 24 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
       Write(column.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 25 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
       Write(column.type_of_building);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 26 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
       Write(column.number_of_floors_served);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 27 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
       Write(column.information);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 28 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
       Write(column.notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      </tr>\n");
#nullable restore
#line 30 "/home/lemath/Rocket_Elevators_Customer_Portal/Views/Column/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n  </table>\n</div>\n");
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
