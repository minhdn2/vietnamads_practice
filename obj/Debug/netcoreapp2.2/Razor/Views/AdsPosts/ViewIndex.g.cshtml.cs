#pragma checksum "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1ba3879dd456458f8f687abcc53463a3e94fe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdsPosts_ViewIndex), @"mvc.1.0.view", @"/Views/AdsPosts/ViewIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdsPosts/ViewIndex.cshtml", typeof(AspNetCore.Views_AdsPosts_ViewIndex))]
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
#line 6 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
using VietnamAds_Practice.Models.Base;

#line default
#line hidden
#line 7 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f1ba3879dd456458f8f687abcc53463a3e94fe6", @"/Views/AdsPosts/ViewIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94665376120d56196f59a833dee0dfd3fe43af7", @"/Views/_ViewImports.cshtml")]
    public class Views_AdsPosts_ViewIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VietnamAds_Practice.Models.AdsPost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
  
    ViewData["Title"] = "ViewIndex";

#line default
#line hidden
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(174, 156, true);
            WriteLiteral("\r\n<style type=\"text/css\">\r\n    a:hover {\r\n        text-decoration: none;\r\n    }\r\n</style>\r\n<div class=\"container\">\r\n    <div class=\"col-lg-8 col-md-12\">\r\n\r\n");
            EndContext();
#line 17 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(379, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(391, 4269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f1ba3879dd456458f8f687abcc53463a3e94fe64747", async() => {
                BeginContext(443, 43, true);
                WriteLiteral("\r\n                <div class=\"card mb-2\">\r\n");
                EndContext();
                BeginContext(610, 92, true);
                WriteLiteral("                    <div class=\"card-body\">\r\n                        <h6 class=\"card-title\">");
                EndContext();
                BeginContext(703, 10, false);
#line 25 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                          Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(713, 138, true);
                WriteLiteral("</h6>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-3\">\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 851, "\"", 870, 1);
#line 28 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
WriteAttributeValue("", 857, item.LogoUrl, 857, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(871, 195, true);
                WriteLiteral(" class=\"rounded img-fluid\" />\r\n                            </div>\r\n                            <div class=\"col-md-9\">\r\n                                <div class=\"text-truncate text-secondary\">\r\n");
                EndContext();
#line 33 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                       var description = item.Description.Replace(Environment.NewLine, " - ");

#line default
#line hidden
                BeginContext(1253, 43, true);
                WriteLiteral("                                    <small>");
                EndContext();
                BeginContext(1297, 21, false);
#line 34 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                      Write(Html.Raw(description));

#line default
#line hidden
                EndContext();
                BeginContext(1318, 231, true);
                WriteLiteral("</small>\r\n                                </div>\r\n                                <div class=\"text-secondary\">\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-md-6\">\r\n");
                EndContext();
#line 39 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                              var price = (item.Price == null && item.Price_IsDealable) ? "Price Dealable" : item.Price?.ToString("n", new NumberFormatInfo { NumberGroupSeparator = "." });

#line default
#line hidden
                BeginContext(1756, 74, true);
                WriteLiteral("                                            <small class=\"card-text\">Giá: ");
                EndContext();
                BeginContext(1831, 5, false);
#line 40 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                                                     Write(price);

#line default
#line hidden
                EndContext();
                BeginContext(1836, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1838, 24, false);
#line 40 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                                                            Write(item.Price_UnitOfMeasure);

#line default
#line hidden
                EndContext();
                BeginContext(1862, 191, true);
                WriteLiteral("</small>\r\n                                        </div>\r\n                                        <div class=\"col-md-6\">\r\n                                            <small class=\"card-text\">");
                EndContext();
                BeginContext(2054, 40, false);
#line 43 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                                                Write(item.CreatedDate.ToString("dd/MMM/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(2094, 465, true);
                WriteLiteral(@"</small>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            [Soc Son, Ha Noi]
                                        </div>
                                        <div class=""col-md-6"">
                                            <small class=""card-text"">");
                EndContext();
                BeginContext(2560, 17, false);
#line 51 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                                                Write(item.AdsForm.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2577, 290, true);
                WriteLiteral(@"</small>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <small class=""card-text"">");
                EndContext();
                BeginContext(2868, 11, false);
#line 56 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                                                Write(item.Nature);

#line default
#line hidden
                EndContext();
                BeginContext(2879, 122, true);
                WriteLiteral("</small>\r\n                                        </div>\r\n                                        <div class=\"col-md-6\">\r\n");
                EndContext();
#line 59 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                               var size = Math.Round(item.Size_Length * item.Size_Width, 0, MidpointRounding.AwayFromZero);
                                                var size_unitOfMeasure = "";
                                                switch (item.Size_UnitOfMeasure)
                                                {
                                                    case "Milimeters":
                                                        size_unitOfMeasure = "mm2";
                                                        break;
                                                    case "Centimeters":
                                                        size_unitOfMeasure = "cm2";
                                                        break;
                                                    case "Meters":
                                                        size_unitOfMeasure = "m2";
                                                        break;
                                                }
                                                if (size > 0)
                                                {

#line default
#line hidden
                BeginContext(4177, 82, true);
                WriteLiteral("                                                    <small class=\"card-text\">Trên ");
                EndContext();
                BeginContext(4260, 4, false);
#line 75 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                                                             Write(size);

#line default
#line hidden
                EndContext();
                BeginContext(4264, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4266, 18, false);
#line 75 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                                                                   Write(size_unitOfMeasure);

#line default
#line hidden
                EndContext();
                BeginContext(4284, 10, true);
                WriteLiteral("</small>\r\n");
                EndContext();
#line 76 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                                }
                                            

#line default
#line hidden
                BeginContext(4392, 264, true);
                WriteLiteral(@"                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            ");
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
#line 19 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(4660, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "C:\WorkSpace\WorkSpace_SideProjects\minh.duong\VietnamAds_Practice\Views\AdsPosts\ViewIndex.cshtml"
        }

#line default
#line hidden
            BeginContext(4673, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VietnamAds_Practice.Models.AdsPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
