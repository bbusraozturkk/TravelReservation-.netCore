#pragma checksum "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1a8083303a86261062fefc4973de0d51460036da6323b6031f4589a803f60a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Member_Views_Reservation_MyOldReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyOldReservation.cshtml")]
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
#line 1 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
 using Entity_layer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1a8083303a86261062fefc4973de0d51460036da6323b6031f4589a803f60a2e", @"/Areas/Member/Views/Reservation/MyOldReservation.cshtml")]
    #nullable restore
    internal sealed class Areas_Member_Views_Reservation_MyOldReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
       List<Reservation>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
  
    ViewData["Title"] = "MyOldReservation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Geçmiş Rezervasyonlar</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Lokasyon</th>\r\n        <th>Kişi Sayısı</th>\r\n        <th>Rezervasyon Tarihi</th>\r\n        <th>Durum</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 21 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                 item.ReservationID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 22 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                 item.Destination.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 23 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                 item.PersonCount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 24 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                 item.ReservationDate.ToString("dd.MM.yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 25 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                 item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "D:\TravelReservation\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
