#pragma checksum "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7afafd432e035dbe5b909710e77403aaa38d0fa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssetDetails_Index), @"mvc.1.0.view", @"/Views/AssetDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AssetDetails/Index.cshtml", typeof(AspNetCore.Views_AssetDetails_Index))]
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
#line 1 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\_ViewImports.cshtml"
using AssetManagementSystemFidrox;

#line default
#line hidden
#line 2 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\_ViewImports.cshtml"
using AssetManagementSystemFidrox.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afafd432e035dbe5b909710e77403aaa38d0fa5", @"/Views/AssetDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52f03044384757b9048854552c201b32afc64f8", @"/Views/_ViewImports.cshtml")]
    public class Views_AssetDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AssetManagementSystemFidrox.Models.AssetDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 290, true);
            WriteLiteral(@"
<br />
<br />
<br />
<br />
<style>
    .style-one a {
        text-decoration: none;
        color:white;
    }
</style>
<div class=""row"">
    <div class=""col-6"">
        <h2 class=""text-info"">List Of Assets</h2>
    </div>
   
    <div class=""col-6 text-right"">
        ");
            EndContext();
            BeginContext(449, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7afafd432e035dbe5b909710e77403aaa38d0fa54680", async() => {
                BeginContext(493, 13, true);
                WriteLiteral("Add New Asset");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(510, 174, true);
            WriteLiteral("\r\n    </div>\r\n    <br /><br />\r\n    <div>\r\n        <table class=\"table table-striped border\">\r\n            <tr class=\"table-info\">\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(685, 35, false);
#line 31 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.AssetId));

#line default
#line hidden
            EndContext();
            BeginContext(720, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(788, 36, false);
#line 34 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_No));

#line default
#line hidden
            EndContext();
            BeginContext(824, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(892, 38, false);
#line 37 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_name));

#line default
#line hidden
            EndContext();
            BeginContext(930, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(998, 38, false);
#line 40 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_type));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1104, 42, false);
#line 43 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_model_no));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1214, 40, false);
#line 46 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.AstProcessor));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1322, 36, false);
#line 49 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_OS));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1426, 40, false);
#line 52 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_Ram_GB));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1534, 45, false);
#line 55 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_HardDisk_GB));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1647, 49, false);
#line 58 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_graphics_crd_GB));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1764, 44, false);
#line 61 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_LicenseKey));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1876, 39, false);
#line 64 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_Mouse));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1983, 42, false);
#line 67 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_Bag_Name));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2093, 41, false);
#line 70 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_Charger));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2202, 40, false);
#line 73 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_Status));

#line default
#line hidden
            EndContext();
            BeginContext(2242, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2310, 41, false);
#line 76 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Asset_Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 44, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
            EndContext();
#line 79 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2452, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2513, 34, false);
#line 83 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.AssetId));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2615, 35, false);
#line 86 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_No));

#line default
#line hidden
            EndContext();
            BeginContext(2650, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2718, 37, false);
#line 89 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_name));

#line default
#line hidden
            EndContext();
            BeginContext(2755, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2823, 37, false);
#line 92 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_type));

#line default
#line hidden
            EndContext();
            BeginContext(2860, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2928, 41, false);
#line 95 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_model_no));

#line default
#line hidden
            EndContext();
            BeginContext(2969, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3037, 39, false);
#line 98 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.AstProcessor));

#line default
#line hidden
            EndContext();
            BeginContext(3076, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3144, 35, false);
#line 101 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_OS));

#line default
#line hidden
            EndContext();
            BeginContext(3179, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3247, 39, false);
#line 104 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_Ram_GB));

#line default
#line hidden
            EndContext();
            BeginContext(3286, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3354, 44, false);
#line 107 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_HardDisk_GB));

#line default
#line hidden
            EndContext();
            BeginContext(3398, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3466, 48, false);
#line 110 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_graphics_crd_GB));

#line default
#line hidden
            EndContext();
            BeginContext(3514, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3582, 43, false);
#line 113 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_LicenseKey));

#line default
#line hidden
            EndContext();
            BeginContext(3625, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3693, 38, false);
#line 116 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_Mouse));

#line default
#line hidden
            EndContext();
            BeginContext(3731, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3799, 41, false);
#line 119 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_Bag_Name));

#line default
#line hidden
            EndContext();
            BeginContext(3840, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3908, 40, false);
#line 122 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_Charger));

#line default
#line hidden
            EndContext();
            BeginContext(3948, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4016, 39, false);
#line 125 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_Status));

#line default
#line hidden
            EndContext();
            BeginContext(4055, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4123, 40, false);
#line 128 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.DisplayFor(m => item.Asset_Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(4163, 106, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td class=\"btn btn-primary style-one a\" >\r\n                    ");
            EndContext();
            BeginContext(4270, 63, false);
#line 132 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { AssetId = item.AssetId }));

#line default
#line hidden
            EndContext();
            BeginContext(4333, 103, true);
            WriteLiteral(" \r\n                </td>\r\n                <td class=\"btn btn-danger style-one a\">\r\n                    ");
            EndContext();
            BeginContext(4437, 133, false);
#line 135 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { AssetId = item.AssetId }, new { onclick = "return confirm('Are sure wants to delete?');" }));

#line default
#line hidden
            EndContext();
            BeginContext(4570, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(5270, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 147 "C:\Users\User\Downloads\AssetManagementSystemFidrox\AssetManagementSystemFidrox\Views\AssetDetails\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5304, 42, true);
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AssetManagementSystemFidrox.Models.AssetDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
