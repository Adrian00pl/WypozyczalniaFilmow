#pragma checksum "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4d20af74e82084813f9b1e057272c436b315338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Koszyk_Index), @"mvc.1.0.view", @"/Views/Koszyk/Index.cshtml")]
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
#line 1 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\_ViewImports.cshtml"
using WypozyczalniaFilmow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\_ViewImports.cshtml"
using WypozyczalniaFilmow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d20af74e82084813f9b1e057272c436b315338", @"/Views/Koszyk/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea29a1b44ce4fa9550589cac2d15838f84337a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Koszyk_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WypozyczalniaFilmow.Models.Film>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <th>Nazwa</th>\r\n        <th>Ilosc</th>\r\n        <th>Wartosc</th>\r\n    </tr>\r\n");
#nullable restore
#line 11 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
     foreach(var film in ViewBag.cart)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 243, "\"", 270, 2);
            WriteAttributeValue("", 248, "cartItem-", 248, 9, true);
#nullable restore
#line 13 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
WriteAttributeValue("", 257, film.Film.Id, 257, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>");
#nullable restore
#line 14 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
           Write(film.Film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><span");
            BeginWriteAttribute("id", " id=\"", 334, "\"", 365, 2);
            WriteAttributeValue("", 339, "itemQuantity-", 339, 13, true);
#nullable restore
#line 15 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
WriteAttributeValue("", 352, film.Film.Id, 352, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
                                                 Write(film.Ilosc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
           Write(film.Wartosc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł</td>\r\n            <td><a href =\"#\" class=\"trash\" data-id=\"");
#nullable restore
#line 17 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
                                               Write(film.Film.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Usun</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div id=\"totalPrice\">\r\n    Razem: ");
#nullable restore
#line 22 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Koszyk\Index.cshtml"
      Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4d20af74e82084813f9b1e057272c436b3153386840", async() => {
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
                WriteLiteral(@"
<script type=""text/javascript"">
    $("".trash"").click(function () {
        var IdCartItem = $(this).data(""id"");
        if (IdCartItem != '') {
            $.post(""/Koszyk/Usun"", { ""id"": IdCartItem },
                function (response) {
                    if (response.itemQuantity == 0) {
                       
                        $(""#cartItem-"" + response.itemId).fadeOut(""slow"");
                    }
                    else {
                        $(""#itemQuantity-"" + response.itemId).text(response.itemQuanity);
                    }
                    $(""#totalPrice"").text(""Razem: "" + response.cartValue + ""zł"")
                });
        }
    });
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WypozyczalniaFilmow.Models.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
