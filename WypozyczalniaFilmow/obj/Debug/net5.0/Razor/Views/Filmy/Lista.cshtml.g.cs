#pragma checksum "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcbed7f1d2f462880a363a58ecc812a852a8bc08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmy_Lista), @"mvc.1.0.view", @"/Views/Filmy/Lista.cshtml")]
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
#line 1 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\_ViewImports.cshtml"
using WypozyczalniaFilmow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\_ViewImports.cshtml"
using WypozyczalniaFilmow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbed7f1d2f462880a363a58ecc812a852a8bc08", @"/Views/Filmy/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea29a1b44ce4fa9550589cac2d15838f84337a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Filmy_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WypozyczalniaFilmow.Models.FilmyKategorie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<H1>Top 3 filmy</H1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Tytuł</th>\r\n            <th>Opis</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
         foreach (var film in Model.FilmyNajnowsze)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
               Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
               Write(film.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n<H1>Top 3 najdluzsze filmy</H1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Tytuł</th>\r\n            <th>Opis</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
         foreach (var film in Model.FilmyNajdluzsze)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
               Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
               Write(film.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>

</table>

<H1>Filmy</H1>
<table>
    <thead>
        <tr>
            <th>Tytuł</th>
            <th>Rezyser</th>
            <th>Data dodania</th>
            <th>Cena</th>
            <th>Dlugosc</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 58 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
         foreach (var film in Model.FilmyKategoria)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
           Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 62 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
           Write(film.Rezyser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 63 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
           Write(film.DataDodania);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
           Write(film.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
           Write(film.DlFilmu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1449, "\"", 1512, 1);
#nullable restore
#line 66 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
WriteAttributeValue("", 1456, Url.Action("Szczegoly","Filmy",new { idFilmu= film.Id}), 1456, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Szczegoly</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\110\source\repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WypozyczalniaFilmow.Models.FilmyKategorie> Html { get; private set; }
    }
}
#pragma warning restore 1591
