#pragma checksum "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f45c25e69d9a42886cc308df95a74d4233ba492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f45c25e69d9a42886cc308df95a74d4233ba492", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b98c5a0f1333e151a21964850271ba0ad94585", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f45c25e69d9a42886cc308df95a74d4233ba4923939", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\"> Yazar Kayıt Sayfası</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 13 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                using(Html.BeginForm("Index","Register",FormMethod.Post))
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom01\">İsim Soyisim</label>\r\n                            ");
#nullable restore
#line 18 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.WriterName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 19 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterName,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">Mail Adresinizi Giriniz</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                   Write(Html.TextBoxFor(x=>x.WriterMail,new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterMail,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Parola</label>
                            ");
#nullable restore
#line 31 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.WriterPassword, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 32 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterPassword,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword2 mb-2\">Görsel Dosya Yolu</label>\r\n                          ");
#nullable restore
#line 36 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                     Write(Html.TextBoxFor(x=>x.WriterImage,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterImage,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                    </div>
                    <button type=""submit"" class=""btn btn-primary submit mb-4"">Kayıt Ol</button>
                    <p>
                        <a href=""#"" id=""btn1"">Kaydol'a tıklayarak, şartlarınızı kabul ediyorum.</a>
                    </p>
");
#nullable restore
#line 45 "C:\Users\Alican\Source\Repos\EksiSozlukttt\MvcProjeKampi\MvcProjeKampi\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <br />
    <script>
    $('#btn1').click(function()
    {
        swal(""sistemimizde vermiş olduğunuz mail adresinize bilgi ve haber postaları spam ölçüsüne takılmadan mail adresinize gönderilecektir"");
    });
    </script>
</section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
