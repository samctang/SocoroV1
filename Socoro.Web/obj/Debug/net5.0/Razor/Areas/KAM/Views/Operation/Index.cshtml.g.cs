#pragma checksum "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fa1d716888e3ca3bfa1a2ce7940c3cca5711480"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_KAM_Views_Operation_Index), @"mvc.1.0.view", @"/Areas/KAM/Views/Operation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fa1d716888e3ca3bfa1a2ce7940c3cca5711480", @"/Areas/KAM/Views/Operation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b3abe8b1da85b2d6804f34046c4f8701e0ff6c", @"/Areas/_ViewImports.cshtml")]
    public class Areas_KAM_Views_Operation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("language", new global::Microsoft.AspNetCore.Html.HtmlString("JavaScript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateOperation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "In Progress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Completed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\Index.cshtml"
  
    ViewData["Title"] = "Operations";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa1d716888e3ca3bfa1a2ce7940c3cca57114806593", async() => {
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
<div class=""subheader py-2 subheader-transparent"" id=""kt_subheader"">
</div>
<!--end::Subheader-->
<!--begin::Entry-->
<div class=""d-flex flex-column-fluid"">
    <div class=""container"">
            <div class=""card card-custom"">
                <div class=""card-header flex-wrap border-0 pt-6 pb-0"">
                    <div class=""card-title"">
                        <h3 class=""card-label"">
                            Operations
                        </h3>
                    </div>
                    <div class=""card-toolbar"">
                        <!--begin::Dropdown-->
                        <div class=""dropdown dropdown-inline mr-2"">
                            <button type=""button"" class=""btn btn-light-primary font-weight-bolder dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""svg-icon svg-icon-md"">
                                    <!--begin::Svg Icon | path:assets/media/svg");
            WriteLiteral(@"/icons/Design/PenAndRuller.svg-->
                                    <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"">
                                        <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                            <rect x=""0"" y=""0"" width=""24"" height=""24"" />
                                            <path d=""M3,16 L5,16 C5.55228475,16 6,15.5522847 6,15 C6,14.4477153 5.55228475,14 5,14 L3,14 L3,12 L5,12 C5.55228475,12 6,11.5522847 6,11 C6,10.4477153 5.55228475,10 5,10 L3,10 L3,8 L5,8 C5.55228475,8 6,7.55228475 6,7 C6,6.44771525 5.55228475,6 5,6 L3,6 L3,4 C3,3.44771525 3.44771525,3 4,3 L10,3 C10.5522847,3 11,3.44771525 11,4 L11,19 C11,19.5522847 10.5522847,20 10,20 L4,20 C3.44771525,20 3,19.5522847 3,19 L3,16 Z"" fill=""#000000"" opacity=""0.3"" />
                                            <path d=""M16,3 L19,3 C20.1045695,3 21,3.8954305 21,5 L21,15.2485298 C2");
            WriteLiteral(@"1,15.7329761 20.8241635,16.200956 20.5051534,16.565539 L17.8762883,19.5699562 C17.6944473,19.7777745 17.378566,19.7988332 17.1707477,19.6169922 C17.1540423,19.602375 17.1383289,19.5866616 17.1237117,19.5699562 L14.4948466,16.565539 C14.1758365,16.200956 14,15.7329761 14,15.2485298 L14,5 C14,3.8954305 14.8954305,3 16,3 Z"" fill=""#000000"" />
                                        </g>
                                    </svg>
                                    <!--end::Svg Icon-->
                                </span>Export
                            </button>
                            <!--begin::Dropdown Menu-->
                            <div class=""dropdown-menu dropdown-menu-sm dropdown-menu-right"">
                                <!--begin::Navigation-->
                                <ul class=""navi flex-column navi-hover py-2"">
                                    <li class=""navi-header font-weight-bolder text-uppercase font-size-sm text-primary pb-2"">Choose an option:</li>
           ");
            WriteLiteral(@"                         <li class=""navi-item"">
                                        <a href=""#"" class=""navi-link"">
                                            <span class=""navi-icon"">
                                                <i class=""la la-print""></i>
                                            </span>
                                            <span class=""navi-text"">Print</span>
                                        </a>
                                    </li>
                                    <li class=""navi-item"">
                                        <a href=""#"" class=""navi-link"">
                                            <span class=""navi-icon"">
                                                <i class=""la la-copy""></i>
                                            </span>
                                            <span class=""navi-text"">Copy</span>
                                        </a>
                                    </li>
                               ");
            WriteLiteral(@"     <li class=""navi-item"">
                                        <a href=""#"" class=""navi-link"">
                                            <span class=""navi-icon"">
                                                <i class=""la la-file-excel-o""></i>
                                            </span>
                                            <span class=""navi-text"">Excel</span>
                                        </a>
                                    </li>
                                    <li class=""navi-item"">
                                        <a href=""#"" class=""navi-link"">
                                            <span class=""navi-icon"">
                                                <i class=""la la-file-text-o""></i>
                                            </span>
                                            <span class=""navi-text"">CSV</span>
                                        </a>
                                    </li>
                                    <l");
            WriteLiteral(@"i class=""navi-item"">
                                        <a href=""#"" class=""navi-link"">
                                            <span class=""navi-icon"">
                                                <i class=""la la-file-pdf-o""></i>
                                            </span>
                                            <span class=""navi-text"">PDF</span>
                                        </a>
                                    </li>
                                </ul>
                                <!--end::Navigation-->
                            </div>
                            <!--end::Dropdown Menu-->
                        </div>
                        <!--end::Dropdown-->
                        <!--begin::Modal Button-->
                        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modal"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""24px"" hei");
            WriteLiteral(@"ght=""24px"" viewBox=""0 0 24 24"" version=""1.1"">
                                <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                    <rect x=""0"" y=""0"" width=""24"" height=""24"" />
                                    <circle fill=""#000000"" cx=""9"" cy=""15"" r=""6"" />
                                    <path d=""M8.8012943,7.00241953 C9.83837775,5.20768121 11.7781543,4 14,4 C17.3137085,4 20,6.6862915 20,10 C20,12.2218457 18.7923188,14.1616223 16.9975805,15.1987057 C16.9991904,15.1326658 17,15.0664274 17,15 C17,10.581722 13.418278,7 9,7 C8.93357256,7 8.86733422,7.00080962 8.8012943,7.00241953 Z"" fill=""#000000"" opacity=""0.3"" />
                                </g>
                            </svg>
                            New Operation
                        </button>
                        <div class=""modal fade"" id=""modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdrop"" aria-hidden=""true"">
                            <div class=""modal-dialog""");
            WriteLiteral(@" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"">New Operation</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <i aria-hidden=""true"" class=""ki ki-close""></i>
                                        </button>
                                    </div>
                                    <div class=""modal-body"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6fa1d716888e3ca3bfa1a2ce7940c3cca571148016044", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!--end::Modal Button-->
                    </div>
                </div>
                <div class=""card-body"">
                    <!--begin::Search Form-->
                    <div class=""mb-7"">
                        <div class=""row align-items-center"">
                            <div class=""col-lg-9 col-xl-8"">
                                <div class=""row align-items-center"">
                                    <div class=""col-md-4 my-2 my-md-0"">
                                        <div class=""input-icon"">
                                            <input type=""text"" class=""form-control"" placeholder=""Search..."" id=""kt_datatable_search_query"" />
                                            <span>
                                                <i class=""flaticon2-search-1 text-muted""></i>
                  ");
            WriteLiteral(@"                          </span>
                                        </div>
                                    </div>
                                    <div class=""col-md-4 my-2 my-md-0"">
                                        <div class=""d-flex align-items-center"">
                                            <label class=""mr-3 mb-0 d-none d-md-block"">Status:</label>
                                            <select class=""form-control"" id=""kt_datatable_search_status"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa1d716888e3ca3bfa1a2ce7940c3cca571148018788", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa1d716888e3ca3bfa1a2ce7940c3cca571148019955", async() => {
                WriteLiteral("In Progress");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa1d716888e3ca3bfa1a2ce7940c3cca571148021168", async() => {
                WriteLiteral("Completed");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                    <div class=""col-md-4 my-2 my-md-0"">
                                        <div class=""d-flex align-items-center"">
                                            <label class=""mr-3 mb-0 d-none d-md-block"">Type:</label>
                                            <select class=""form-control"" id=""kt_datatable_search_type"" name=""TypeId""></select>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--end: Search Form-->
                    <!--begin: Datatable-->
                    <div class=""datatable datatable-bordered datatable-head-custom"" id=""kt_datatable""></div>
                    <!--end: Datatable-->
                </di");
            WriteLiteral(@"v>
            </div>
            <!--end::Card-->
    </div>
    <!--end::Entry-->
</div>
<!--end::Content-->

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
#line 169 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\Index.cshtml"
                         Write(Environment.GetEnvironmentVariable("ApiEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/operation/0/1/10',
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
            sortable: true,

            pagination: true,

            search: {
                input: $('#kt_datatable_search_query'),
                key: 'generalSearch'
            },

            rows: {
                autoHide: false
            },

            columns: [{
                field: 'operationNo',
                title: 'Follow Up #'
            }, {
                field: 'typeId',
                title: 'Type',
                template: function (row) {
                    var result = """";
                    $.ajax({
                        url:");
            WriteLiteral(" \"");
#nullable restore
#line 205 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\Index.cshtml"
                         Write(Environment.GetEnvironmentVariable("ApiEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""+""/OperationType/""+ row.typeId,
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
                field: 'progress',
                title: 'Progress',
                template: function (row) {
                    var range = row.progress / 25;
                    var divClass = '';
                        switch (range) {
                            case 0:
                                divClass = 'bg-danger';
                                break;
                            case 1:
                                divClass = 'bg-danger';
                                break;
                            case 2:
                                divC");
            WriteLiteral(@"lass = 'bg-primary';
                                break;
                            case 3:
                                divClass = 'bg-primary';
                                break;
                            case 4:
                                divClass = 'bg-success';
                                break;
                        }
                    return '\
                        <span class=""text-muted mr-2 font-size-sm font-weight-bold"">'+row.progress+'%</span >\
                        <span class=""text-muted font-size-sm font-weight-bold"">Progress</span>\
                        <div class=""progress progress-xs w-100"">\
                            <div class=""progress-bar '+ divClass + '"" role=""progressbar"" style=""width: ' + row.progress + '%;"" aria-valuenow=""'+row.progress+'"" aria-valuemin=""0"" aria-valuemax=""100"">\
                            </div >\
                        </div >';
                }
            }, {
                field: 'status',
             ");
            WriteLiteral(@"   title: 'Status',
                template: function (row) {
                    var spanClass = '';
                    switch (row.status) {
                        case 'In Progress':
                            spanClass = 'label-light-primary';
                            break;
                        case 'Completed':
                            spanClass = 'label-light-success';
                            break;
                    }
                    return '<span class=""label font-weight-bold label-lg label-inline '+spanClass+'""> ' + row.status + '</span >';
                    }
            }, {
                field: 'agent',
                title: 'Agent',
                template: function (row) {
                    var result = """";
                    $.ajax({
                        url: """);
#nullable restore
#line 268 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\Index.cshtml"
                         Write(Environment.GetEnvironmentVariable("ApiEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""+""/Customer/""+ row.agent,
                        data: {},
                        dataType: 'json',
                        traditional: true,
                        async: false,
                        success: function (data) {
                            result = data;
                        }
                    });
                    return result.data.companyName;
                }
            }, {
                field: 'shipper',
                title: 'Shipper',
                template: function (row) {
                    var result = """";
                    $.ajax({
                        url: """);
#nullable restore
#line 285 "C:\git\Socoro\Socoro.Web\Areas\KAM\Views\Operation\Index.cshtml"
                         Write(Environment.GetEnvironmentVariable("ApiEndpoint"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""+""/Customer/""+ row.shipper,
                        data: {},
                        dataType: 'json',
                        traditional: true,
                        async: false,
                        success: function (data) {
                            result = data;
                        }
                    });
                    return result.data.companyName;
                }
            }, {
                field: 'submittedDate',
                title: 'Created Date',
                template: function (row) {
                    return row.submittedDate.substring(0, 10);
                    },
            }]
        });

        datatable.sort('submittedDate', 'desc');

        $('#kt_datatable_search_status').on('change', function () {
                datatable.search($(this).val(), 'status');
        });

        $('#kt_datatable_search_type').on('change', function () {
                datatable.search($(this).val(), 'typeId');
        });

        $('#k");
            WriteLiteral(@"t_datatable_search_status, #kt_datatable_search_type').selectpicker();

        $(datatable.table).on('click', 'tbody tr', function () {
            var data = $(this).children(""td"").eq(0).text();
            $.ajax({
                url: ""/KAM/Operation/GetOperationDetails/"",
                type: 'POST',
                data: JSON.stringify(data),
                contentType: 'application/json; charset=utf-8',
                processData: true,
                success: function (result) {
                    location.href = ""/KAM/OperationView/"";
                }
            })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
