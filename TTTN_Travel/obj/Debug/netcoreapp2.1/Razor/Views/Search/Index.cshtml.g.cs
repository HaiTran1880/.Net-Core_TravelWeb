#pragma checksum "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "661864fc27304f766f2ce7132c572949d7a47503"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Index.cshtml", typeof(AspNetCore.Views_Search_Index))]
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
#line 1 "F:\TTTN_Travel\TTTN_Travel\Views\_ViewImports.cshtml"
using TTTN_Travel;

#line default
#line hidden
#line 2 "F:\TTTN_Travel\TTTN_Travel\Views\_ViewImports.cshtml"
using TTTN_Travel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661864fc27304f766f2ce7132c572949d7a47503", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bfeaa89f9c33738f47d5b4e675891302441d09b", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout_Page.cshtml";

#line default
#line hidden
            BeginContext(95, 40, true);
            WriteLiteral("<div>\r\n    <div style=\"display:block\">\r\n");
            EndContext();
#line 8 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
         if (ViewBag.TourTN != null)
        {

#line default
#line hidden
            BeginContext(184, 38, true);
            WriteLiteral("            <h2>Tour Trong Nước</h2>\r\n");
            EndContext();
#line 11 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
             foreach (var i in ViewBag.TourTN)
            {

#line default
#line hidden
            BeginContext(285, 132, true);
            WriteLiteral("                <div class=\"col-md-4\">\r\n\r\n                    <div class=\"box-dv-tour-page deatil-cate\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 417, "\"", 451, 2);
            WriteAttributeValue("", 424, "/Tours/Details?Id=", 424, 18, true);
#line 16 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
WriteAttributeValue("", 442, i.Idtour, 442, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(452, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(453, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5826bb74a6024235a5fd7b1df8d18081", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 463, "~/images/", 463, 9, true);
#line 16 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
AddHtmlAttributeValue("", 472, i.Image, 472, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 480, "", 481, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(483, 466, true);
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
            BeginWriteAttribute("href", " href=\"", 949, "\"", 983, 2);
            WriteAttributeValue("", 956, "/Tours/Details?Id=", 956, 18, true);
#line 26 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
WriteAttributeValue("", 974, i.Idtour, 974, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(984, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(987, 9, false);
#line 26 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                                                  Write(i.Tentuor);

#line default
#line hidden
            EndContext();
            BeginContext(996, 43, true);
            WriteLiteral("</a>\r\n                                <p>\r\n");
            EndContext();
#line 28 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                     if (i.Danhgia != 0)
                                    {
                                        

#line default
#line hidden
#line 30 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                         for (var k = 1; k <= i.Danhgia; k++)
                                        {

#line default
#line hidden
            BeginContext(1258, 72, true);
            WriteLiteral("                                            <i class=\"fa fa-star\"></i>\r\n");
            EndContext();
#line 33 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                        }

#line default
#line hidden
#line 33 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(1412, 198, true);
            WriteLiteral("                                </p>\r\n                            </div>\r\n                            <div class=\"icon-content\">\r\n                                <p><i class=\"fa fa-map-marker\"></i> ");
            EndContext();
            BeginContext(1611, 11, false);
#line 38 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                                               Write(i.Lichtrinh);

#line default
#line hidden
            EndContext();
            BeginContext(1622, 158, true);
            WriteLiteral(" </p>\r\n                                <p>\r\n                                    <i class=\"\tfa fa-pencil-square-o\"></i>\r\n\r\n                                    ");
            EndContext();
            BeginContext(1781, 8, false);
#line 42 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                               Write(i.Ngaybd);

#line default
#line hidden
            EndContext();
            BeginContext(1789, 747, true);
            WriteLiteral(@".
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
            BeginContext(2537, 5, false);
#line 54 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                              Write(i.Gia);

#line default
#line hidden
            EndContext();
            BeginContext(2542, 136, true);
            WriteLiteral(" đ</b>/khách\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
            EndContext();
#line 60 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
            }

#line default
#line hidden
#line 60 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2704, 16, true);
            WriteLiteral("    </div>\r\n\r\n\r\n");
            EndContext();
#line 65 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
     if (ViewBag.TourNN != null)
    {

#line default
#line hidden
            BeginContext(2761, 75, true);
            WriteLiteral("        <div style=\"display:block\">\r\n            <h2>Tour Nước Ngoài</h2>\r\n");
            EndContext();
#line 69 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
             foreach (var i in ViewBag.TourNN)
            {

#line default
#line hidden
            BeginContext(2899, 132, true);
            WriteLiteral("                <div class=\"col-md-4\">\r\n\r\n                    <div class=\"box-dv-tour-page deatil-cate\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3031, "\"", 3060, 2);
            WriteAttributeValue("", 3038, "/Tout/Details?Id=", 3038, 17, true);
#line 74 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
WriteAttributeValue("", 3055, i.Id, 3055, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3061, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3062, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ad90586d5774824b460d2238dfc54e7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3072, "~/images/", 3072, 9, true);
#line 74 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
AddHtmlAttributeValue("", 3081, i.Image, 3081, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 3089, "", 3090, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3092, 466, true);
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
            BeginWriteAttribute("href", " href=\"", 3558, "\"", 3587, 2);
            WriteAttributeValue("", 3565, "/Tout/Details?Id=", 3565, 17, true);
#line 84 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
WriteAttributeValue("", 3582, i.Id, 3582, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3588, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(3591, 5, false);
#line 84 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                                             Write(i.Ten);

#line default
#line hidden
            EndContext();
            BeginContext(3596, 43, true);
            WriteLiteral("</a>\r\n                                <p>\r\n");
            EndContext();
#line 86 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                     if (i.Rate != 0)
                                    {
                                        

#line default
#line hidden
#line 88 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                         for (var k = 1; k <= i.Rate; k++)
                                        {

#line default
#line hidden
            BeginContext(3852, 72, true);
            WriteLiteral("                                            <i class=\"fa fa-star\"></i>\r\n");
            EndContext();
#line 91 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                        }

#line default
#line hidden
#line 91 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(4006, 198, true);
            WriteLiteral("                                </p>\r\n                            </div>\r\n                            <div class=\"icon-content\">\r\n                                <p><i class=\"fa fa-map-marker\"></i> ");
            EndContext();
            BeginContext(4205, 11, false);
#line 96 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                                               Write(i.Lichtrinh);

#line default
#line hidden
            EndContext();
            BeginContext(4216, 158, true);
            WriteLiteral(" </p>\r\n                                <p>\r\n                                    <i class=\"\tfa fa-pencil-square-o\"></i>\r\n\r\n                                    ");
            EndContext();
            BeginContext(4375, 6, false);
#line 100 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                               Write(i.Ngay);

#line default
#line hidden
            EndContext();
            BeginContext(4381, 746, true);
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
            BeginContext(5128, 7, false);
#line 112 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                              Write(i.Giakm);

#line default
#line hidden
            EndContext();
            BeginContext(5135, 136, true);
            WriteLiteral(" đ</b>/khách\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
            EndContext();
#line 118 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5286, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 120 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(5309, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 124 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
     if (ViewBag.TinTuc != null)
    {

#line default
#line hidden
            BeginContext(5356, 57, true);
            WriteLiteral("<div style=\"display:block\">\r\n    <h2>Tin liên quan</h2>\r\n");
            EndContext();
#line 128 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
     foreach (var i in ViewBag.TinTuc)
    {

#line default
#line hidden
            BeginContext(5460, 90, true);
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"img-box-left\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5550, "\"", 5578, 2);
            WriteAttributeValue("", 5557, "/News/Detail?Id=", 5557, 16, true);
#line 132 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
WriteAttributeValue("", 5573, i.Id, 5573, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5579, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(5581, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "969005fa9ab5467e91215e8784b02bd7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5591, "~/images/", 5591, 9, true);
#line 132 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
AddHtmlAttributeValue("", 5600, i.Anhtintuc, 5600, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5614, 109, true);
            WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"title-box-right\">\r\n                <div class=\"title-h4\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5723, "\"", 5751, 2);
            WriteAttributeValue("", 5730, "/News/Detail?Id=", 5730, 16, true);
#line 135 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
WriteAttributeValue("", 5746, i.Id, 5746, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5752, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5754, 8, false);
#line 135 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
                                                                 Write(i.Tomtat);

#line default
#line hidden
            EndContext();
            BeginContext(5762, 31, true);
            WriteLiteral("</a></div>\r\n                <p>");
            EndContext();
            BeginContext(5794, 9, false);
#line 136 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
              Write(i.Chitiet);

#line default
#line hidden
            EndContext();
            BeginContext(5803, 81, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"space\"></div>\r\n        </div>\r\n");
            EndContext();
#line 140 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(5891, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 142 "F:\TTTN_Travel\TTTN_Travel\Views\Search\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5914, 12, true);
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
