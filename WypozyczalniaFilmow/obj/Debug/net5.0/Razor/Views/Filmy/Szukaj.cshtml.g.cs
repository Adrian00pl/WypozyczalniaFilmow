#pragma checksum "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2417a5d60fcada3f22663d2d9e79c3f12056aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmy_Szukaj), @"mvc.1.0.view", @"/Views/Filmy/Szukaj.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2417a5d60fcada3f22663d2d9e79c3f12056aa", @"/Views/Filmy/Szukaj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea29a1b44ce4fa9550589cac2d15838f84337a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Filmy_Szukaj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WypozyczalniaFilmow.Models.Film>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div>\r\n        <H1>Szukana fraza: ");
#nullable restore
#line 3 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
                      Write(ViewBag.Fraza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</H1>\r\n        <table>\r\n            <thead>\r\n                <tr>\r\n                    <th>Tytu??</th>\r\n                    <th>Opis</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
                 foreach (var film in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 15 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
                       Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 16 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
                       Write(film.Rezyser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 17 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
                       Write(film.DataDodania);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 18 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
                       Write(film.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 19 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
                       Write(film.DlFilmu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 732, 1);
#nullable restore
#line 20 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
WriteAttributeValue("", 676, Url.Action("Szczegoly","Filmy",new { idFilmu= film.Id}), 676, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Szczegoly</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szukaj.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WypozyczalniaFilmow.Models.Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
