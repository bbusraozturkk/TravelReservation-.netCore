#pragma checksum "D:\TravelReservation\Views\Shared\Components\_DestinationStatistic2\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64f33be7ddaad962afaa4888c634575b4e4ce06cf2f4cd134c1a4e974e6bece0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components__DestinationStatistic2_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DestinationStatistic2/Default.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\TravelReservation\Views\_ViewImports.cshtml"
using TravelReservation

#nullable disable
    ;
#nullable restore
#line 2 "D:\TravelReservation\Views\_ViewImports.cshtml"
using TravelReservation.Areas.Member.Models

#nullable disable
    ;
#nullable restore
#line 3 "D:\TravelReservation\Views\_ViewImports.cshtml"
using Entity_layer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"64f33be7ddaad962afaa4888c634575b4e4ce06cf2f4cd134c1a4e974e6bece0", @"/Views/Shared/Components/_DestinationStatistic2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"12e79a2bda324edae4c2801dfb9f00ff155ea1f9e1c3427cf186504443df49b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components__DestinationStatistic2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sneat-1.0.0/assets/img/icons/unicons/wallet.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"﻿<div class=""col-md-6 col-lg-4 order-1 mb-4"">
    <div class=""card h-100"">
        <div class=""card-header"">
            <ul class=""nav nav-pills"" role=""tablist"">
                <li class=""nav-item"">
                    <button type=""button""
                            class=""nav-link active""
                            role=""tab""
                            data-bs-toggle=""tab""
                            data-bs-target=""#navs-tabs-line-card-income""
                            aria-controls=""navs-tabs-line-card-income""
                            aria-selected=""true"">
                        Income
                    </button>
                </li>
                <li class=""nav-item"">
                    <button type=""button"" class=""nav-link"" role=""tab"">Expenses</button>
                </li>
                <li class=""nav-item"">
                    <button type=""button"" class=""nav-link"" role=""tab"">Profit</button>
                </li>
            </ul>
        </div>
        <div c");
            WriteLiteral(@"lass=""card-body px-0"">
            <div class=""tab-content p-0"">
                <div class=""tab-pane fade show active"" id=""navs-tabs-line-card-income"" role=""tabpanel"">
                    <div class=""d-flex p-4 pt-3"">
                        <div class=""avatar flex-shrink-0 me-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64f33be7ddaad962afaa4888c634575b4e4ce06cf2f4cd134c1a4e974e6bece05706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div>
                            <small class=""text-muted d-block"">Total Balance</small>
                            <div class=""d-flex align-items-center"">
                                <h6 class=""mb-0 me-1"">$459.10</h6>
                                <small class=""text-success fw-semibold"">
                                    <i class=""bx bx-chevron-up""></i>
                                    42.9%
                                </small>
                            </div>
                        </div>
                    </div>
                    <div id=""incomeChart""></div>
                    <div class=""d-flex justify-content-center pt-4 gap-2"">
                        <div class=""flex-shrink-0"">
                            <div id=""expensesOfWeek""></div>
                        </div>
                        <div>
                            <p class=""mb-n1 mt-1"">Expenses This Week</p>
                            <small ");
            WriteLiteral("class=\"text-muted\">$39 less than last week</small>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
