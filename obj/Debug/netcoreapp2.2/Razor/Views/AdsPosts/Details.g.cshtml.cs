#pragma checksum "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d55b67db9c0892d8fd0ec9a47a0df8fec8db55b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdsPosts_Details), @"mvc.1.0.view", @"/Views/AdsPosts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdsPosts/Details.cshtml", typeof(AspNetCore.Views_AdsPosts_Details))]
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
#line 1 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\_ViewImports.cshtml"
using VietnamAds_Practice;

#line default
#line hidden
#line 2 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\_ViewImports.cshtml"
using VietnamAds_Practice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55b67db9c0892d8fd0ec9a47a0df8fec8db55b6", @"/Views/AdsPosts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94665376120d56196f59a833dee0dfd3fe43af7", @"/Views/_ViewImports.cshtml")]
    public class Views_AdsPosts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietnamAds_Practice.Models.AdsPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>AdsPost</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(217, 41, false);
#line 14 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(258, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(320, 37, false);
#line 17 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(357, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(418, 41, false);
#line 20 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(459, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(521, 37, false);
#line 23 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(558, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(619, 52, false);
#line 26 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price_IsDealable));

#line default
#line hidden
            EndContext();
            BeginContext(671, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(733, 48, false);
#line 29 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price_IsDealable));

#line default
#line hidden
            EndContext();
            BeginContext(781, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(842, 43, false);
#line 32 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LogoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(885, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(947, 39, false);
#line 35 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.LogoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(986, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1047, 43, false);
#line 38 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdsForm));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1152, 42, false);
#line 41 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdsForm.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1255, 45, false);
#line 44 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdsVendor));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1362, 44, false);
#line 47 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdsVendor.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1467, 40, false);
#line 50 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1569, 36, false);
#line 53 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1666, 47, false);
#line 56 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1775, 43, false);
#line 59 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1879, 47, false);
#line 62 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1988, 43, false);
#line 65 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2092, 47, false);
#line 68 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2201, 43, false);
#line 71 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2305, 47, false);
#line 74 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2352, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2414, 43, false);
#line 77 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeletedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2457, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2504, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55b67db9c0892d8fd0ec9a47a0df8fec8db55b613986", async() => {
                BeginContext(2550, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2558, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2566, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55b67db9c0892d8fd0ec9a47a0df8fec8db55b616325", async() => {
                BeginContext(2588, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(2604, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietnamAds_Practice.Models.AdsPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
