#pragma checksum "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\OperationView\_ViewInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96905fd37e17c2b92c6bcb462f9464ecfe8923d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_KAM_Views_OperationView__ViewInfo), @"mvc.1.0.view", @"/Areas/KAM/Views/OperationView/_ViewInfo.cshtml")]
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
#line 1 "C:\git\Socoro\Socoro.Web\Areas\_ViewImports.cshtml"
using Socoro.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\Socoro\Socoro.Web\Areas\_ViewImports.cshtml"
using Socoro.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\Socoro\Socoro.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\Socoro\Socoro.Web\Areas\_ViewImports.cshtml"
using Socoro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\Socoro\Socoro.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\Socoro\Socoro.Web\Areas\_ViewImports.cshtml"
using Socoro.Application.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\Socoro\Socoro.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96905fd37e17c2b92c6bcb462f9464ecfe8923d1", @"/Areas/KAM/Views/OperationView/_ViewInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b3abe8b1da85b2d6804f34046c4f8701e0ff6c", @"/Areas/_ViewImports.cshtml")]
    public class Areas_KAM_Views_OperationView__ViewInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Socoro.Web.Areas.KAM.Models.OperationIntViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""viewInfo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdrop"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Relevant Operation Information</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <i aria-hidden=""true"" class=""ki ki-close""></i>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""bg-white rounded p-10"">
                    <!--begin::Card-->
                    <div class=""card card-custom card-fit card-border"">
                        <div class=""card-header"">
                            <div class=""card-title"">
                                <h3 class=""card-label"">Agent</h3>
                            </div>
                        </div>
                        <div class=""card-body p");
            WriteLiteral(@"t-2"">
                            <p><strong>Company Name</strong>: <span class=""AgentCompany""></span></p>
                            <br />
                            <p><strong>Email Address</strong>: <span class=""AgentEmail""></span></p>
                            <br />
                            <p><strong>Phone Number</strong>: <span class=""AgentPhone""></span></p>
                            <br />
                            <p><strong>Contact Name</strong>: <span class=""AgentName""></span></p>
                            <br />
                        </div>
                    </div>
                    <br />
                    <!--end::Card-->
                    <div class=""card card-custom card-fit card-border"">
                        <div class=""card-header"">
                            <div class=""card-title"">
                                <h3 class=""card-label"">Shipper</h3>
                            </div>
                        </div>
                        <div c");
            WriteLiteral(@"lass=""card-body pt-2"">
                            <p><strong>Company Name</strong>: <span class=""ShipperCompany""></span></p>
                            <br />
                            <p><strong>Email Address</strong>: <span class=""ShipperEmail""></span></p>
                            <br />
                            <p><strong>Phone Number</strong>: <span class=""ShipperPhone""></span></p>
                            <br />
                            <p><strong>Contact Name</strong>: <span class=""ShipperName""></span></p>
                            <br />
                        </div>
                    </div>
                    <br />
                    <div class=""card card-custom card-fit card-border"">
                        <div class=""card-header"">
                            <div class=""card-title"">
                                <h3 class=""card-label"">Consignee</h3>
                            </div>
                        </div>
                        <div class=""card-");
            WriteLiteral(@"body pt-2"">
                            <p><strong>Company Name</strong>: <span class=""ConsigneeCompany""></span></p>
                            <br />
                            <p><strong>Email Address</strong>: <span class=""ConsigneeEmail""></span></p>
                            <br />
                            <p><strong>Phone Number</strong>: <span class=""ConsigneePhone""></span></p>
                            <br />
                            <p><strong>Contact Name</strong>: <span class=""ConsigneeName""></span></p>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Socoro.Web.Areas.KAM.Models.OperationIntViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
