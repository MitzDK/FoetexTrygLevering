#pragma checksum "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3e6b89f4131e7557450796263003688983085b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoetexTrygLevering.Pages.Users.DeliveryDriver.Pages_Users_DeliveryDriver_OrderHistorik), @"mvc.1.0.razor-page", @"/Pages/Users/DeliveryDriver/OrderHistorik.cshtml")]
namespace FoetexTrygLevering.Pages.Users.DeliveryDriver
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
#line 2 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
using FoetexTrygLevering.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
using FoetexTrygLevering.Models.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3e6b89f4131e7557450796263003688983085b", @"/Pages/Users/DeliveryDriver/OrderHistorik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63e32d403c74ee87d454804f0847ea50b70328f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_DeliveryDriver_OrderHistorik : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
  
    Layout = "Shared/_DeliveryLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
Write(Model.Driver.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<table class=""table table-bordered table-hover table-striped table-opacity"">
    <thead>
    <tr>
        <th>
            OrderID
        </th>
        <th>
            Name of the Customer
        </th>
        <th>
            Total Price
        </th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
     if (Model.Driver.OrderHistory.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
         foreach (Order ord in @Model.Driver.OrderHistory)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
               Write(ord.OrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
               Write(ord.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
               Write(ord.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\OrderHistorik.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoetexTrygLevering.Pages.Users.DeliveryDriver.OrderHistorikModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoetexTrygLevering.Pages.Users.DeliveryDriver.OrderHistorikModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoetexTrygLevering.Pages.Users.DeliveryDriver.OrderHistorikModel>)PageContext?.ViewData;
        public FoetexTrygLevering.Pages.Users.DeliveryDriver.OrderHistorikModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
