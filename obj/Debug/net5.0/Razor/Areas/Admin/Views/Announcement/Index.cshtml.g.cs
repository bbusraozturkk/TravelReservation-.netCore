#pragma checksum "D:\TravelReservation\Areas\Admin\Views\Announcement\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2436de4f85a7b3f5459a8d5cd0fc0231606c9ef2b834ca0d2d74f65272c53173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_Announcement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2436de4f85a7b3f5459a8d5cd0fc0231606c9ef2b834ca0d2d74f65272c53173", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_Announcement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\TravelReservation\Areas\Admin\Views\Announcement\Index.cshtml"
       List<DTOLayer.DTOs.AnnouncementDTOs.AnnouncementListDto>

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
#line 2 "D:\TravelReservation\Areas\Admin\Views\Announcement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Başlık</th>\r\n        <th>İçerik</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "D:\TravelReservation\Areas\Admin\Views\Announcement\Index.cshtml"
     foreach (var item in Model)
    {



#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 19 "D:\TravelReservation\Areas\Admin\Views\Announcement\Index.cshtml"
                 item.AnnouncementID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 20 "D:\TravelReservation\Areas\Admin\Views\Announcement\Index.cshtml"
                 item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 21 "D:\TravelReservation\Areas\Admin\Views\Announcement\Index.cshtml"
                 item.Content

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-dark\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "D:\TravelReservation\Areas\Admin\Views\Announcement\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n<a href=\"/Admin/Announcement/Announcement\" class=\"btn btn-primary\">Yeni Duyuru</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DTOLayer.DTOs.AnnouncementDTOs.AnnouncementListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
