#pragma checksum "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad10396abf945c491fdf6de0a059dcbd306e388"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#line 1 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\_ViewImports.cshtml"
using MvcProjeKampi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\_ViewImports.cshtml"
using MvcProjeKampi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad10396abf945c491fdf6de0a059dcbd306e388", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b98c5a0f1333e151a21964850271ba0ad94585", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Writer/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Blog Güncelleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 8 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
 using(Html.BeginForm("EditBlog","Blog",FormMethod.Post))
{
   

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogId,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("   <br />\r\n");
#nullable restore
#line 13 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTitle,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("   <br />\r\n");
#nullable restore
#line 16 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kuçük Resim Adresi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTumbnailImage,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("   <br />\r\n");
#nullable restore
#line 19 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Resmi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogImage,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("   <br />\r\n");
#nullable restore
#line 22 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kategorisi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryId,(List<SelectListItem>)ViewBag.cv,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
                                                                                                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("   <br />\r\n");
#nullable restore
#line 25 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x=>x.BlogContent,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("   <br />\r\n   <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 29 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Blog\EditBlog.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
