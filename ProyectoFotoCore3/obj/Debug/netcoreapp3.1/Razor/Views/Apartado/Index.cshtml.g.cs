#pragma checksum "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Apartado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acbb3d1bc2d964de3a80837141b3ce12a1bbdc3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Apartado_Index), @"mvc.1.0.view", @"/Views/Apartado/Index.cshtml")]
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
#line 1 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\_ViewImports.cshtml"
using ProyectoFotoCore3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\_ViewImports.cshtml"
using ProyectoFotoCore3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbb3d1bc2d964de3a80837141b3ce12a1bbdc3c", @"/Views/Apartado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b19a2db015981e57f0b1065d345b4de929b17dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Apartado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Common/util.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""row mg-top-xl"">
    <div class=""col s12 container-flex "">
        <div>
            <span class=""text-title"">Apartados</span>
        </div>
        <div>
            <button class=""btn waves-effect waves-light green"" id=""btnAdd"">Añadir</button>
        </div>
        
    </div>
</div>

<div id=""modalApartado"">

</div>
<div class=""row"">
    <div id=""tablaApartado"" class=""col s12 m7 l9 xl8"">

        

    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acbb3d1bc2d964de3a80837141b3ce12a1bbdc3c4070", async() => {
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
                WriteLiteral("-\r\n    <script>\r\n        $(document).ready(function () {\r\n            LoadPartial(\"tablaApartado\", \"");
#nullable restore
#line 29 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Apartado\Index.cshtml"
                                     Write(Url.Action("GetTabla","Apartado"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"GET\", null);\r\n\r\n            $(\"#btnAdd\").click(function () {\r\n                LoadPartial(\"modalApartado\", \"");
#nullable restore
#line 32 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Apartado\Index.cshtml"
                                         Write(Url.Action("Create","Apartado"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"GET\", null);\r\n\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
