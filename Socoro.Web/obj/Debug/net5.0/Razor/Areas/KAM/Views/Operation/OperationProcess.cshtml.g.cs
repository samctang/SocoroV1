#pragma checksum "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\OperationProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c3525d667de6f547a642d878371a24685826d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_KAM_Views_Operation_OperationProcess), @"mvc.1.0.view", @"/Areas/KAM/Views/Operation/OperationProcess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c3525d667de6f547a642d878371a24685826d7", @"/Areas/KAM/Views/Operation/OperationProcess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b3abe8b1da85b2d6804f34046c4f8701e0ff6c", @"/Areas/_ViewImports.cshtml")]
    public class Areas_KAM_Views_Operation_OperationProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Socoro.Web.Areas.KAM.Models.OperationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("language", new global::Microsoft.AspNetCore.Html.HtmlString("JavaScript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c3525d667de6f547a642d878371a24685826d75039", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!--begin::Subheader-->
<div class=""subheader py-2 py-lg-6 subheader-transparent"" id=""kt_subheader"">
    <div class=""container d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap"">
        <!--begin::Info-->
        <div class=""d-flex align-items-center flex-wrap"">
            <!--begin::Page Title-->
            <div class=""dropdown mt-2 mb-2 mr-3 ml-5"">
                <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    Actions
                </button>
                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                    <a class=""dropdown-item"" href=""#"">View Info</a>
                    <a class=""dropdown-item"" href=""#"">Input SLI</a>
                    <a class=""dropdown-item"" href=""#"">Request SLI</a>
                    <a class=""dropdown-item"" href=""#"">Input Invoice</a>
                    <a class=""dropdown-item"" href=""#"">Requ");
            WriteLiteral(@"est Invoice</a>
                    <a class=""dropdown-item"" href=""#"">Input Insurance</a>
                    <a class=""dropdown-item"" href=""#"">Edit Operation</a>
                    <a class=""dropdown-item"" href=""#"">Send All Documentation</a>
                </div>
            </div>
            <div class=""dropdown mt-2 mb-2"">
                <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    View Files
                </button>
                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                    <a class=""dropdown-item"" href=""#"">SLI</a>
                    <a class=""dropdown-item"" href=""#"">Booking Sheet</a>
                    <a class=""dropdown-item"" href=""#"">Insurance</a>
                </div>
            </div>
            <!--end::Page Title-->
        </div>
        <!--end::Info-->
        <!--begin::Toolbar-->
        <div class=""d-flex align-it");
            WriteLiteral(@"ems-center flex-wrap"">
            <div class=""dropdown mt-2 mb-2 mr-5"">
                <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    Difficulty
                </button>
                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                    <a class=""dropdown-item"" href=""#"">Easy</a>
                    <a class=""dropdown-item"" href=""#"">Medium</a>
                    <a class=""dropdown-item"" href=""#"">Hard</a>
                </div>
            </div>
        </div>
        <!--end::Toolbar-->
    </div>
</div>
<!--end::Subheader-->
<!--begin::Entry-->
<div class=""d-flex flex-column-fluid"">
    <div class=""container"">
        <!--end::Content-->
        <div class=""col-lg-12"">
            <!--begin::Advance Table Widget 1-->
            <div class=""card card-custom card-stretch gutter-b"">
                <!--begin::Header-->
                <div class=""");
            WriteLiteral("card-header border-0 py-5\">\n                    <h3 class=\"card-title align-items-start flex-column\">\n                        <span class=\"card-label font-weight-bolder text-dark\">Viewing Operation #");
#nullable restore
#line 64 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\OperationProcess.cshtml"
                                                                                            Write(Model.OperationNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </h3>
                </div>
                <!--end::Header-->
                <div class=""card-body"">
                    <!--begin: Datatable-->
                    <div class=""datatable datatable-bordered datatable-head-custom"" id=""kt_datatable""></div>
                    <!--end: Datatable-->
                </div>
                <!--end::Body-->
                <!--begin::Modals-->
                <div class=""modal fade"" id=""modal"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdrop"" aria-hidden=""true"">
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"">New Operation</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <i aria-hidden=""true"" class=""ki ki-close""></i>
            ");
            WriteLiteral(@"                    </button>
                            </div>
                            <div class=""modal-body"">

                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-light-primary font-weight-bold"" data-dismiss=""modal"">Close</button>
                                <button type=""button"" class=""btn btn-primary font-weight-bold"">Submit</button>
                            </div>
                        </div>
                    </div>
                </div>
                <!--end::Modals-->
            </div>
            <!--end::Advance Table Widget 1-->
        </div>
    </div>
    <!--end::Entry-->
</div>

<script>
    var initDataTable = function () {
        var datatable = $('#kt_datatable').KTDatatable({
            // datasource definition
            data: {
                type: 'remote',
                source: {
                    read: {
                        url: '");
#nullable restore
#line 110 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\OperationProcess.cshtml"
                         Write(Environment.GetEnvironmentVariable("ApiEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/OperationProcess/\' + ");
#nullable restore
#line 110 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\OperationProcess.cshtml"
                                                                                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                        method: 'GET'
                    },
                },
                pageSize: 10,
            },

            // layout definition
            layout: {
                scroll: true, // enable/disable datatable scroll both horizontal and vertical when needed.
                footer: false // display/hide footer
            },

            // column sorting
            sortable: false,

            pagination: false,

            search: {
                input: $('#kt_datatable_search_query'),
                key: 'generalSearch'
            },

            rows: {
                autoHide: false
            },

            columns: [{
                field: 'process',
                title: 'Step',
                template: function (row) {
                    var result = """";
                    $.ajax({
                        url: """);
#nullable restore
#line 143 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\OperationProcess.cshtml"
                         Write(Environment.GetEnvironmentVariable("ApiEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""+""/OperationProcessType/0/""+ row.typeId,
                        data: {},
                        dataType: 'json',
                        traditional: true,
                        async: false,
                        success: function (data) {
                            result = data;
                        }
                    });
                    return result.data.process;
                }
            }, {
                field: 'description',
                title: 'Objective',
                template: function (row) {
                    var result = """";
                    $.ajax({
                        url: """);
#nullable restore
#line 160 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\OperationProcess.cshtml"
                         Write(Environment.GetEnvironmentVariable("ApiEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""+""/OperationProcessType/0/""+ row.typeId,
                        data: {},
                        dataType: 'json',
                        traditional: true,
                        async: false,
                        success: function (data) {
                            result = data;
                        }
                    });
                    return result.data.description;
                }
            }, {
                field: 'status',
                title: 'Status',
            }]
        });

        $(datatable.table).on('click', 'tbody tr', function () {
            console.log($(this).data('row'));
            $('#modal').modal('show');
        });
    };

    $(document).ready(function () {
        initDataTable();
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Socoro.Web.Areas.KAM.Models.OperationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
