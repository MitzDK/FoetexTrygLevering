#pragma checksum "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f49bdd9e5ac67d22ce249b4265f1888804e19e16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoetexTrygLevering.Pages.Users.DeliveryDriver.Pages_Users_DeliveryDriver_ActiveOrder), @"mvc.1.0.razor-page", @"/Pages/Users/DeliveryDriver/ActiveOrder.cshtml")]
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
#line 2 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
using FoetexTrygLevering.Models.Items;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f49bdd9e5ac67d22ce249b4265f1888804e19e16", @"/Pages/Users/DeliveryDriver/ActiveOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63e32d403c74ee87d454804f0847ea50b70328f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_DeliveryDriver_ActiveOrder : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "OrderHistorik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "NewOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
  
    Layout = "Shared/_DeliveryLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered table-hover table-striped table-opacity"" width=""40%"">
    <thead>
    <tr>
        <th>
            Postnr
        </th>
        <th>
            Adresse
        </th>
        <th>
            Pris
        </th>
        <th></th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>
            ");
#nullable restore
#line 26 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
       Write(Model.Order.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 29 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
       Write(Model.Order.DeliveryCity);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 29 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
                                  Write(Model.Order.DeliveryStreet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 32 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
       Write(Model.Order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f49bdd9e5ac67d22ce249b4265f1888804e19e166762", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f49bdd9e5ac67d22ce249b4265f1888804e19e167036", async() => {
                    WriteLiteral("Done!");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
                                                                         WriteLiteral(Model.Order.OrderID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    </tbody>\r\n    <thead");
            BeginWriteAttribute("class", " class=\"", 994, "\"", 1002, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <tr>\r\n        <td>\r\n            <b>Billede</b>\r\n        </td>\r\n        <td>\r\n            <b>Navn</b>\r\n        </td>\r\n        <td>\r\n            <b>Hvor mange</b>\r\n        </td>\r\n        <td></td>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
     foreach (ShoppingItem shopItem in @Model.Order.ShoppedItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1370, "\"", 1400, 1);
#nullable restore
#line 60 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
WriteAttributeValue("", 1376, shopItem.Item.ImageName, 1376, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1401, "\"", 1407, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"orderitem-picture\">\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
           Write(shopItem.Item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
           Write(shopItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\victo\Desktop\FoetexTrygLevering\FoetexTrygLevering\Pages\Users\DeliveryDriver\ActiveOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoetexTrygLevering.Pages.Users.DeliveryDriver.ActiveOrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoetexTrygLevering.Pages.Users.DeliveryDriver.ActiveOrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoetexTrygLevering.Pages.Users.DeliveryDriver.ActiveOrderModel>)PageContext?.ViewData;
        public FoetexTrygLevering.Pages.Users.DeliveryDriver.ActiveOrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
