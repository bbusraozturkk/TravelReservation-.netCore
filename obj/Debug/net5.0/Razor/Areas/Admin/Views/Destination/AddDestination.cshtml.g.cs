#pragma checksum "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63b75d981a54a9b8851d8f973534927d68e41fb7c34f96992b90699e8bd40b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_Destination_AddDestination), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/AddDestination.cshtml")]
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
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"63b75d981a54a9b8851d8f973534927d68e41fb7c34f96992b90699e8bd40b98", @"/Areas/Admin/Views/Destination/AddDestination.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_Destination_AddDestination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
       Entity_layer.Concrete.Destination

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
  
    ViewData["Title"] = "AddDestination";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Yeni Rota Oluşturma Sayfası</h1>\r\n<form method=\"post\">\r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 10 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Şehir")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"text\" asp-for=\"City\" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 14 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Gün Gece")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"date\" asp-for=\"DayNight\" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 18 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Fiyat")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"text\" asp-for=\"Price\" class=\"form-control\" />\r\n    </div>  \r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 22 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Ana Görsel")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"text\" asp-for=\"Image\" class=\"form-control\" />\r\n    </div> \r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 26 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Kapasite")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"text\" asp-for=\"Capacity\" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 30 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Kapak Görseli")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"text\" asp-for=\"CoverImage\" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 34 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Görsel 2")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"text\" asp-for=\"Image2\" class=\"form-control\" />\r\n    </div> \r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 38 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Detay 1")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"text\" asp-for=\"Details1\" class=\"form-control\" />\r\n    </div> \r\n    <div class=\"form-group\">\r\n        ");
            Write(
#nullable restore
#line 42 "D:\TravelReservation\Areas\Admin\Views\Destination\AddDestination.cshtml"
         Html.Label("Detay 2")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        <input type=\"text\" asp-for=\"Details2\" class=\"form-control\" />\r\n    </div>\r\n    <button class=\"btn btn-success\">Kaydet</button>\r\n</form>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entity_layer.Concrete.Destination> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
