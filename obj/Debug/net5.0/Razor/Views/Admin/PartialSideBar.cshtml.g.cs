#pragma checksum "D:\TravelReservation\Views\Admin\PartialSideBar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6146f04115adb88009e8d64b2d97a5f717306cab0b665eb8b55ce64b84183421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Admin_PartialSideBar), @"mvc.1.0.view", @"/Views/Admin/PartialSideBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6146f04115adb88009e8d64b2d97a5f717306cab0b665eb8b55ce64b84183421", @"/Views/Admin/PartialSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"12e79a2bda324edae4c2801dfb9f00ff155ea1f9e1c3427cf186504443df49b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Admin_PartialSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""menu-inner py-1"">
    <!-- Dashboard -->
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-grid-alt""></i>
            <div data-i18n=""Analytics"">Dashboard</div>
        </a>
    </li>

    <!-- Rotalar -->
    <li class=""menu-item"">
        <a href=""/Admin/Destination/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-map""></i>
            <div data-i18n=""Analytics"">Rotalar</div>
        </a>
    </li>

    <!-- Yorumlar -->
    <li class=""menu-item"">
        <a href=""/Admin/Comment/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-comment-detail""></i>
            <div data-i18n=""Analytics"">Yorumlar</div>
        </a>
    </li>
     <li class=""menu-item"">
        <a href=""/ExcelReport/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-comment-detail""></i>
            <div data-i18n=""Analytics"">Raporlar</div>
        </a>
    </li>");
            WriteLiteral(@"

    <!-- Misafirler -->
    <li class=""menu-item"">
        <a href=""/Admin/User/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-user""></i>
            <div data-i18n=""Analytics"">Misafirler</div>
        </a>
    </li>

    <!-- Mesajlar -->
    <li class=""menu-item"">
        <a href=""/Admin/ContactUs/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-envelope""></i>
            <div data-i18n=""Analytics"">Mesajlar</div>
        </a>
    </li>

    <!-- Rehberlerimiz -->
    <li class=""menu-item"">
        <a href=""/Admin/Guide/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-book-open""></i>
            <div data-i18n=""Analytics"">Rehberlerimiz</div>
        </a>
    </li>

    <!-- Öne Çıkanlar -->
    <li class=""menu-item"">
        <a href=""/Admin/Mail/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Mail Gönder</div>
        </a>
 ");
            WriteLiteral(@"   </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Öne Çıkanlar</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Referanslar</div>
        </a>
    </li> 
    
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Alt Hakkında</div>
        </a>
    </li>
     <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Rezervasyonlar</div>
        </a>
    </li>
      <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx ");
            WriteLiteral(@"bx-star""></i>
            <div data-i18n=""Analytics"">Mail Listesi</div>
        </a>
    </li>     
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Öne Çıkanlar 2</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Şifre İşlemleri</div>
        </a>
    </li>
     <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Rol İşlemleri</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-star""></i>
            <div data-i18n=""Analytics"">Çıkış Yap</div>
        </a>
    </li>

</ul>
");
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
