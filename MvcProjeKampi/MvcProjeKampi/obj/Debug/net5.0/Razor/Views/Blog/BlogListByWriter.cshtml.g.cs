#pragma checksum "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a83abc2ddba04309bec49245c5d2b570f3fe88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\_ViewImports.cshtml"
using MvcProjeKampi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\_ViewImports.cshtml"
using MvcProjeKampi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a83abc2ddba04309bec49245c5d2b570f3fe88", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b98c5a0f1333e151a21964850271ba0ad94585", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Writer/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Blog Başlığı</th>\r\n        <th>Oluşturma Tarihi</th>\r\n        <th>Kategori</th>\r\n        <th>Durum</th>\r\n        <th>Sil</th>\r\n        <th>Duzenle</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td> ");
#nullable restore
#line 22 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
        Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
       Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a href=\"#\" class=\"btn btn-danger\">Sil</a></td>\r\n         <td><a href=\"#\" class=\"btn btn-warning\">Düzenle</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Alican\Source\Repos\EksiSozluk\MvcProjeKampi\MvcProjeKampi\Views\Blog\BlogListByWriter.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"#\" class=\"btn btn-primary\">Yeni Blog Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591