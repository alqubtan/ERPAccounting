#pragma checksum "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c198ae73098be3e7ff2960ea6394f889d6b8bdda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdvancePayments_Delete), @"mvc.1.0.view", @"/Views/AdvancePayments/Delete.cshtml")]
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
#nullable restore
#line 1 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\_ViewImports.cshtml"
using SamaERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\_ViewImports.cshtml"
using SamaERP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c198ae73098be3e7ff2960ea6394f889d6b8bdda", @"/Views/AdvancePayments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44153f8c27fb906c48d6d8ddf4fa17d626e0d761", @"/Views/_ViewImports.cshtml")]
    public class Views_AdvancePayments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SamaERP.Models.ACCAdvancePayment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Accounting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdvancePayments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"right_col\" role=\"main\">\r\n  \r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c198ae73098be3e7ff2960ea6394f889d6b8bdda5699", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c198ae73098be3e7ff2960ea6394f889d6b8bdda5969", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input style=\"font-size:small;\" type=\"submit\" value=\"Delete\" class=\"btn btn-danger mb-0\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


        <table class=""table table-bordered table-striped"" width=""100%"">
            <tr>
                <td width=""15%"">
                    <label style=""font-size:medium;font-weight:500;"">Employee  Name :</label>
                </td>
                <td colspan=""3"">
                    <strong style=""font-size:medium;font-weight:700;color:black;"">  ");
#nullable restore
#line 23 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                                                                               Write(Html.DisplayFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                </td>

            </tr>
            <tr>
                <td width=""15%"">
                    <label style=""font-size:medium;font-weight:500;"">Payment Reason :</label>
                </td>
                <td colspan=""3"">
                    <strong style=""font-size:medium;font-weight:700;color:black;"">  ");
#nullable restore
#line 32 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                                                                               Write(Html.DisplayFor(model => model.PaymentReason));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                </td>

            </tr>
            <tr>
                <td width=""15%"">
                    <label style=""font-size:medium;font-weight:500;"">Amount  :</label>
                </td>
                <td width=""35%"">
                    <strong style=""font-size: medium; font-weight: 700; color: black; "">    ");
#nullable restore
#line 41 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Ammount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                </td>
                <td width=""15%"">
                    <label style=""font-size:medium;font-weight:500;"">Currency :</label>
                </td>
                <td width=""35%"">
                    <strong style=""font-size: medium; font-weight: 700; color: black; "">    ");
#nullable restore
#line 47 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>

                </td>
            </tr>
            <tr>
                <td width=""15%"">
                    <label style=""font-size:medium;font-weight:500;"">Approved By :</label>
                </td>
                <td colspan=""3"">
                    <strong style=""font-size: medium; font-weight: 700; color: black; "">   ");
#nullable restore
#line 56 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.ApprovedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>

                </td>

            </tr>
            <tr>
                <td width=""15%"">
                    <label style=""font-size:medium;font-weight:500;"">Added by  :</label>
                </td>
                <td width=""35%"">
                    <strong style=""font-size: medium; font-weight: 700; color: black; "">    ");
#nullable restore
#line 66 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.AddedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                </td>
                <td width=""15%"">
                    <label style=""font-size:medium;font-weight:500;"">Adding Date :</label>
                </td>
                <td width=""35%"">
                    <strong style=""font-size: medium; font-weight: 700; color: black; "">    ");
#nullable restore
#line 72 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.AddingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\r\n                </td>\r\n            </tr>\r\n\r\n\r\n\r\n\r\n\r\n        </table>\r\n\r\n\r\n  \r\n\r\n    <br />\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<h1>Delete  Advance Payments</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c198ae73098be3e7ff2960ea6394f889d6b8bdda14447", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c198ae73098be3e7ff2960ea6394f889d6b8bdda14710", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 118 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n    <br />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c198ae73098be3e7ff2960ea6394f889d6b8bdda16494", async() => {
                    WriteLiteral("Back to Advance Payments List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<hr />

<div class=""section"">
    <div class=""container"" style=""background-color:white;padding:40pt 30pt 40pt 30pt;margin:40pt 30pt 40pt 30pt;border-style:solid;border-color:lightgray;border-width:1pt;"">

        <div class=""form-group"">
            <label for=""inputAddress"">Employee  Name :</label>
            <strong>  ");
#nullable restore
#line 132 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                 Write(Html.DisplayFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"inputAddress\">Payment Reason  :</label>\r\n            <strong>  ");
#nullable restore
#line 136 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                 Write(Html.DisplayFor(model => model.PaymentReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </div>\r\n        <div class=\"form-row\">\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"inputEmail4\">Amount :</label>\r\n                <strong>    ");
#nullable restore
#line 141 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Ammount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"inputPassword4\">Currency :</label>\r\n                <strong>   ");
#nullable restore
#line 145 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                      Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"inputAddress2\">Approved By :</label>\r\n            <strong>   ");
#nullable restore
#line 151 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                  Write(Html.DisplayFor(model => model.ApprovedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </div>\r\n\r\n        <div class=\"form-row\">\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"inputEmail4\"> Added By :</label>\r\n                <strong>      ");
#nullable restore
#line 157 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                         Write(Html.DisplayFor(model => model.AddedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"inputPassword4\">Adding Time :</label>\r\n                <strong>    ");
#nullable restore
#line 161 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.AddingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SamaERP.Models.ACCAdvancePayment> Html { get; private set; }
    }
}
#pragma warning restore 1591