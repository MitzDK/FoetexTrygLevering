#pragma checksum "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494f058032b4bf125b104c4d55c0e8265e9bb7b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoetexTrygLevering.Pages.Users.Admin.Pages_Users_Admin_DebugLists), @"mvc.1.0.razor-page", @"/Pages/Users/Admin/DebugLists.cshtml")]
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
#line 2 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
using FoetexTrygLevering.Models.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494f058032b4bf125b104c4d55c0e8265e9bb7b3", @"/Pages/Users/Admin/DebugLists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63e32d403c74ee87d454804f0847ea50b70328f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Admin_DebugLists : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
 foreach (Order ord in Model.DoneOrders)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 8 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
Write(ord.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
                   Write(ord.IsDelivered);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
                                    Write(ord.ShoppedItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 9 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n^ Done Orderds \r\nV Pending\r\n\r\n");
#nullable restore
#line 14 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
 foreach (Order ord in Model.PendingOrders)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 16 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
    Write(ord.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
                       Write(ord.IsDelivered);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
                                        Write(ord.ShoppedItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 17 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\Admin\DebugLists.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoetexTrygLevering.Pages.Users.Admin.DebugListsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoetexTrygLevering.Pages.Users.Admin.DebugListsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoetexTrygLevering.Pages.Users.Admin.DebugListsModel>)PageContext?.ViewData;
        public FoetexTrygLevering.Pages.Users.Admin.DebugListsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
