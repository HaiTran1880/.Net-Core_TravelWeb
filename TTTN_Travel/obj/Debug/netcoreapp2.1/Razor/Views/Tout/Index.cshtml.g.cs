#pragma checksum "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9561a67345520c95478f4c02cb6e93b81ef160f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tout_Index), @"mvc.1.0.view", @"/Views/Tout/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tout/Index.cshtml", typeof(AspNetCore.Views_Tout_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 7 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\TTTN_Travel\TTTN_Travel\Views\_ViewImports.cshtml"
using TTTN_Travel;

#line default
#line hidden
#line 6 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
using TTTN_Travel.Models;

#line default
#line hidden
#line 9 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 10 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
using X.PagedList.Mvc;

#line default
#line hidden
#line 13 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
using System.IO;

#line default
#line hidden
#line 14 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#line 15 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9561a67345520c95478f4c02cb6e93b81ef160f", @"/Views/Tout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bfeaa89f9c33738f47d5b4e675891302441d09b", @"/Views/_ViewImports.cshtml")]
    public class Views_Tout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Tour>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout_Page.cshtml";

#line default
#line hidden
            BeginContext(385, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
#line 18 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
     foreach (var i in ViewBag.ListTout)
    {

#line default
#line hidden
            BeginContext(455, 108, true);
            WriteLiteral("        <div class=\"col-md-4\">\r\n\r\n            <div class=\"box-dv-tour-page deatil-cate\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 563, "\"", 592, 2);
            WriteAttributeValue("", 570, "/Tout/Details?Id=", 570, 17, true);
#line 23 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
WriteAttributeValue("", 587, i.Id, 587, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(593, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(594, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26837d6937c14c8eb216f58059c97e1a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 604, "~/images/", 604, 9, true);
#line 23 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
AddHtmlAttributeValue("", 613, i.Image, 613, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 621, "", 622, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(624, 402, true);
            WriteLiteral(@"</a>
                <div class=""hot-sale"">
                    <div class=""triangle-left""></div>
                    <div class=""vuong"">	<p><i class=""fa fa-flash""></i>Khuyến mãi</p></div>
                    <div class=""triangle-right""></div>

                </div>
                <div class=""box-conten-tour"">

                    <div class=""title-tour-combo"">
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1055, 2);
            WriteAttributeValue("", 1033, "/Tout/Details?Id=", 1033, 17, true);
#line 33 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
WriteAttributeValue("", 1050, i.Id, 1050, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1056, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(1059, 5, false);
#line 33 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                                                     Write(i.Ten);

#line default
#line hidden
            EndContext();
            BeginContext(1064, 35, true);
            WriteLiteral("</a>\r\n                        <p>\r\n");
            EndContext();
#line 35 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                             if (i.Rate != 0)
                            {
                                

#line default
#line hidden
#line 37 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                                 for (var k = 1; k <= i.Rate; k++)
                                {

#line default
#line hidden
            BeginContext(1280, 64, true);
            WriteLiteral("                                    <i class=\"fa fa-star\"></i>\r\n");
            EndContext();
#line 40 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                                }

#line default
#line hidden
#line 40 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(1410, 166, true);
            WriteLiteral("                        </p>\r\n                    </div>\r\n                    <div class=\"icon-content\">\r\n                        <p><i class=\"fa fa-map-marker\"></i> ");
            EndContext();
            BeginContext(1577, 11, false);
#line 45 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                                                       Write(i.Lichtrinh);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 134, true);
            WriteLiteral(" </p>\r\n                        <p>\r\n                            <i class=\"\tfa fa-pencil-square-o\"></i>\r\n\r\n                            ");
            EndContext();
            BeginContext(1723, 6, false);
#line 49 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                       Write(i.Ngay);

#line default
#line hidden
            EndContext();
            BeginContext(1729, 650, true);
            WriteLiteral(@"
                        </p>
                    </div>
                    <div class=""uu-dai-2"">
                        <p>
                            <a href=""#"">Liên hệ ngay</a>
                            <a class=""icon-contact"" href=""#""><i class=""glyphicon glyphicon-phone""></i></a>
                            <a class=""icon-contact"" href=""#""><i class=""fa fa-facebook-official""></i></a>
                            <a class=""icon-contact"" href=""#""><i class=""glyphicon glyphicon-qrcode""></i></a>
                        </p>
                    </div>
                    <div class=""page-price-tour"">
                        <b>");
            EndContext();
            BeginContext(2380, 7, false);
#line 61 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                      Write(i.Giakm);

#line default
#line hidden
            EndContext();
            BeginContext(2387, 104, true);
            WriteLiteral(" đ</b>/khách\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 67 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2498, 19, true);
            WriteLiteral("</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2518, 107, false);
#line 70 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
Write(Html.PagedListPager((IPagedList)ViewBag.ListTout, page => Url.Action("Index", "Tout", new { page = page })));

#line default
#line hidden
            EndContext();
            BeginContext(2625, 43, true);
            WriteLiteral("\r\n</div>\r\n<script type=\"text/javascript\">\r\n");
            EndContext();
#line 73 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
         if (!ViewData.ModelState.IsValid && ViewData.ModelState["Error"].Errors.Count > 0)
        {
            

#line default
#line hidden
            BeginContext(2790, 69, true);
            WriteLiteral("\r\n            $(document).ready(function() {\r\n                alert(\'");
            EndContext();
            BeginContext(2860, 56, false);
#line 77 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                  Write(ViewData.ModelState["Error"].Errors.First().ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(2916, 34, true);
            WriteLiteral("\');\r\n            });\r\n            ");
            EndContext();
#line 79 "F:\TTTN_Travel\TTTN_Travel\Views\Tout\Index.cshtml"
                   
        }

#line default
#line hidden
            BeginContext(2970, 11, true);
            WriteLiteral("</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Tour>> Html { get; private set; }
    }
}
#pragma warning restore 1591
