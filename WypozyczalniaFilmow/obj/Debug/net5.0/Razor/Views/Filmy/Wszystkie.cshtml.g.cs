#pragma checksum "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Wszystkie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f0de6c115af800b10dd48c34e25d4977a52eac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmy_Wszystkie), @"mvc.1.0.view", @"/Views/Filmy/Wszystkie.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f0de6c115af800b10dd48c34e25d4977a52eac5", @"/Views/Filmy/Wszystkie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea29a1b44ce4fa9550589cac2d15838f84337a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Filmy_Wszystkie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WypozyczalniaFilmow.Models.Film>>
    {
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
#line 2 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Wszystkie.cshtml"
  
    Layout = "_Layout";
 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\" display: flex; flex-direction: column;flex-wrap:wrap\">\r\n    <ul>\r\n");
#nullable restore
#line 7 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Wszystkie.cshtml"
         foreach (var film in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 315, 1);
#nullable restore
#line 10 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Wszystkie.cshtml"
WriteAttributeValue("", 257, Url.Action("Szczegoly", "Filmy", new {idFilmu = film.Id}), 257, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f0de6c115af800b10dd48c34e25d4977a52eac54205", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 327, "~/Grafiki/", 327, 10, true);
#nullable restore
#line 10 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Wszystkie.cshtml"
AddHtmlAttributeValue("", 337, film.Plakat, 337, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 12 "C:\Users\109\Source\Repos\WypozyczalniaFilmow\WypozyczalniaFilmow\Views\Filmy\Wszystkie.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
