#pragma checksum "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szczegoly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e059ebe01aa0c9e1230bd0070aec09eb87d2e01e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmy_Szczegoly), @"mvc.1.0.view", @"/Views/Filmy/Szczegoly.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e059ebe01aa0c9e1230bd0070aec09eb87d2e01e", @"/Views/Filmy/Szczegoly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea29a1b44ce4fa9550589cac2d15838f84337a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Filmy_Szczegoly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Film>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 10 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szczegoly.cshtml"
           Write(Model.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <ul>\r\n                    <li>\r\n                        ");
#nullable restore
#line 15 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szczegoly.cshtml"
                   Write(Model.Rezyser);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        ");
#nullable restore
#line 18 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szczegoly.cshtml"
                   Write(Model.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        ");
#nullable restore
#line 21 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Szczegoly.cshtml"
                   Write(Model.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
