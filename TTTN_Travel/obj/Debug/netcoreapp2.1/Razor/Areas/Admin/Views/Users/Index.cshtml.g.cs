#pragma checksum "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eea6c9465fce363735afa5cb1cfc2dd7c88af65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eea6c9465fce363735afa5cb1cfc2dd7c88af65", @"/Areas/Admin/Views/Users/Index.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TTTN_Travel.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm btn-block mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout_Admin.cshtml";

#line default
#line hidden
            BeginContext(207, 261, true);
            WriteLiteral(@"<div class=""container-fluid"">

    <div class=""row"">
        <div class=""col-xl-12"">
            <div class=""breadcrumb-holder"">
                <h1 class=""main-title float-left"">Customers</h1>
                <p style=""float:right"">
                    ");
            EndContext();
            BeginContext(468, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43b7eeff99604453b7dc80bb8833b2fa", async() => {
                BeginContext(491, 56, true);
                WriteLiteral("<i class=\"fas fa-plus\" aria-hidden=\"true\"></i>Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(551, 646, true);
            WriteLiteral(@"
                </p>
                <div class=""clearfix""></div>
            </div>
        </div>
    </div>
    <!-- end row -->

    <div class=""row"">

        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""dataTable"" class=""table table-bordered table-hover display dataTable no-footer"" style=""width: 100%;"" role=""grid"" aria-describedby=""dataTable_info"">
                        <thead>
                            <tr>
                                <th>
                                    ");
            EndContext();
            BeginContext(1198, 40, false);
#line 32 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 41, true);
            WriteLiteral("\r\n                                </th>\r\n");
            EndContext();
            BeginContext(1412, 74, true);
            WriteLiteral("                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1487, 44, false);
#line 38 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1647, 40, false);
#line 41 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Pass));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1803, 41, false);
#line 44 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1960, 41, false);
#line 47 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2117, 42, false);
#line 50 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2275, 39, false);
#line 53 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Cmt));

#line default
#line hidden
            EndContext();
            BeginContext(2314, 41, true);
            WriteLiteral("\r\n                                </th>\r\n");
            EndContext();
            BeginContext(2483, 145, true);
            WriteLiteral("                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 62 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2717, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2838, 39, false);
#line 66 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2877, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
            BeginContext(3066, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3149, 43, false);
#line 72 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(3192, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3320, 39, false);
#line 75 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Pass));

#line default
#line hidden
            EndContext();
            BeginContext(3359, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3487, 40, false);
#line 78 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3527, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3655, 40, false);
#line 81 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3695, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3823, 41, false);
#line 84 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(3864, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3992, 38, false);
#line 87 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Cmt));

#line default
#line hidden
            EndContext();
            BeginContext(4030, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
            BeginContext(4214, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4296, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497e1c58427b451183080869b46cb504", async() => {
                BeginContext(4382, 31, true);
                WriteLiteral("<i class=\"far fa-edit\"></i>Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(4417, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4459, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c42196fe9364d28a64da1c47b99fe14", async() => {
                BeginContext(4551, 34, true);
                WriteLiteral("<i class=\"fas fa-trash\"></i>Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4589, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 97 "F:\TTTN_Travel\TTTN_Travel\Areas\Admin\Views\Users\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4704, 257, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <!-- end table-responsive-->

            </div>
            <!-- end card-body-->

        </div>
        <!-- end card-->

    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TTTN_Travel.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591