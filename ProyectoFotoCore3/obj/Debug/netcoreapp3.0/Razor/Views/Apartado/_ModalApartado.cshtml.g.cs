#pragma checksum "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Apartado\_ModalApartado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19dd416be6631a3c0b09cb099b7ab8c9d4b367a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Apartado__ModalApartado), @"mvc.1.0.view", @"/Views/Apartado/_ModalApartado.cshtml")]
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
#nullable restore
#line 1 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Apartado\_ModalApartado.cshtml"
using ProyectoFotoCore3.Models.Entities.Apartado.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Apartado\_ModalApartado.cshtml"
using ProyectoFotoCore3.Models.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19dd416be6631a3c0b09cb099b7ab8c9d4b367a8", @"/Views/Apartado/_ModalApartado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b19a2db015981e57f0b1065d345b4de929b17dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Apartado__ModalApartado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApartadoVMO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Apartado\_ModalApartado.cshtml"
  
    var method = Model.StateView == StateViewEnum.Edicion ? "Edit" : "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"modal\">\r\n    <div class=\"modal-content\">\r\n        <input type=\"text\" />\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApartadoVMO> Html { get; private set; }
    }
}
#pragma warning restore 1591
