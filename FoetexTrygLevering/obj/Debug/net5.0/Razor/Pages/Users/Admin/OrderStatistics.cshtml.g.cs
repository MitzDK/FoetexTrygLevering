#pragma checksum "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\OrderStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b2597175fed1b7b36c68264fcd4552d51096e7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoetexTrygLevering.Pages.Users.Admin.Pages_Users_Admin_OrderStatistics), @"mvc.1.0.razor-page", @"/Pages/Users/Admin/OrderStatistics.cshtml")]
namespace FoetexTrygLevering.Pages.Users.Admin
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
#line 1 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\_ViewImports.cshtml"
using FoetexTrygLevering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\OrderStatistics.cshtml"
using FoetexTrygLevering.Models.Items;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b2597175fed1b7b36c68264fcd4552d51096e7f", @"/Pages/Users/Admin/OrderStatistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63e32d403c74ee87d454804f0847ea50b70328f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Admin_OrderStatistics : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\OrderStatistics.cshtml"
  
    Layout = "Shared/_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped"">
    <thead>
    <tr>
        <th>Statistics</th>
        <th>Result</th>
    </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                Which item is the most bought?
            </td>
            <td>");
#nullable restore
#line 19 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\OrderStatistics.cshtml"
           Write(Model.MostBought().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  : ");
#nullable restore
#line 19 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\OrderStatistics.cshtml"
                                       Write(Model.AmountBought(@Model.MostBought()));

#line default
#line hidden
#nullable disable
            WriteLiteral("stk </td>\r\n        </tr>\r\n        <tr>\r\n            <td>How much money has been spent in total?</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\OrderStatistics.cshtml"
           Write(Model.CombinePrices());

#line default
#line hidden
#nullable disable
            WriteLiteral(",-</td>\r\n        </tr>\r\n        <tr>\r\n            <td>How many customers do we have?</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\OrderStatistics.cshtml"
           Write(Model.TotalCustomers());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>How many delivery drivers do we have?</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\OrderStatistics.cshtml"
           Write(Model.TotalDrivers());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoetexTrygLevering.Pages.Users.Admin.OrderStatisticsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoetexTrygLevering.Pages.Users.Admin.OrderStatisticsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoetexTrygLevering.Pages.Users.Admin.OrderStatisticsModel>)PageContext?.ViewData;
        public FoetexTrygLevering.Pages.Users.Admin.OrderStatisticsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
