#pragma checksum "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f09cfea9941c172a97ffb7c23174cd0c11c16446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdvancePayments_Details), @"mvc.1.0.view", @"/Views/AdvancePayments/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09cfea9941c172a97ffb7c23174cd0c11c16446", @"/Views/AdvancePayments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44153f8c27fb906c48d6d8ddf4fa17d626e0d761", @"/Views/_ViewImports.cshtml")]
    public class Views_AdvancePayments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SamaERP.Models.ACCAdvancePayment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""right_col"" role=""main"">
   


        <br />
        <table class=""table table-bordered table-striped"" width=""100%"">
            <tr>
                <td width=""15%"">
                    <label style=""font-size:medium;font-weight:500;"">Employee  Name :</label>
                </td>
                <td colspan=""3"">
                    <strong style=""font-size:medium;font-weight:700;color:black;"">  ");
#nullable restore
#line 20 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml"
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
#line 29 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml"
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
#line 38 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml"
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
#line 44 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml"
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
#line 53 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml"
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
#line 63 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml"
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
#line 69 "C:\Users\hp\Desktop\SamaERP\SamaERP\Views\AdvancePayments\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.AddingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\r\n                </td>\r\n            </tr>\r\n\r\n\r\n         \r\n\r\n\r\n        </table>\r\n\r\n\r\n  \r\n\r\n    <br />\r\n\r\n\r\n</div>\r\n");
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
