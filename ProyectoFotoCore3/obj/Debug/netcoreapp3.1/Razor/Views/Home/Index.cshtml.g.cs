#pragma checksum "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "550248cae1b368f933ea1134698837df3c120f56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Home\Index.cshtml"
using ProyectoFotoCore3.Models.Entities.Home.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"550248cae1b368f933ea1134698837df3c120f56", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b19a2db015981e57f0b1065d345b4de929b17dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVMO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""row mg-top-xl"">
        <div class=""col s12 m9 l8 xl5"">
            <div class=""card"">
                <div class=""card-content"" style=""display:flex; text-align:center;"">
                    <div style=""flex:auto"">
                        <div style=""margin-bottom: 16px;"">
                            <span style=""font-size:18px;"">Fotos</span>
                        </div>
                        <div>
                            <buttom type=""buttom"" class=""btn waves blue lighten-1"">Subir fotos</buttom>
                        </div>
                    </div>
                    <div style=""flex:auto; border-left: 1px solid;"">
                        <div>
                            <span style=""font-size:18px;"">Fotos subidas</span>
                        </div>
                        <div>
                            <span style=""font-size:38px;"">
                                ");
#nullable restore
#line 21 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Home\Index.cshtml"
                           Write(Model.Photos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""col s12 m9 l8 xl5"">
            <div class=""card"">
                <div class=""card-content"" style=""display:flex; text-align:center;"">
                    <div style=""flex:auto"">
                        <div style=""margin-bottom: 16px;"">
                            <span style=""font-size:18px;"">Sesiones</span>
                        </div>
                        <div>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1740, "\"", 1776, 1);
#nullable restore
#line 37 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Home\Index.cshtml"
WriteAttributeValue("", 1747, Url.Action("Index","Sesion"), 1747, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn waves-effect waves-light blue lighten-1"">Gestionar</a>
                        </div>
                    </div>
                    <div style=""flex:auto; border-left: 1px solid;"">
                        <div>
                            <span style=""font-size:18px;"">Sesiones creadas</span>
                        </div>
                        <div>
                            <span style=""font-size:38px;"">
                                ");
#nullable restore
#line 46 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Home\Index.cshtml"
                           Write(Model.Sessions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>

        <div class=""col s12 m9 l8 xl5"">
            <div class=""card"">
                <div class=""card-content"" style=""display:flex; text-align:center;"">
                    <div style=""flex:auto"">
                        <div style=""margin-bottom: 16px;"">
                            <span style=""font-size:18px;"">Apartados</span>
                        </div>
                        <div>
                            <a");
            BeginWriteAttribute("href", " href=\"", 2988, "\"", 3026, 1);
#nullable restore
#line 63 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Home\Index.cshtml"
WriteAttributeValue("", 2995, Url.Action("Index","Apartado"), 2995, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn waves-effect waves-light blue lighten-1"">Gestionar</a>
                        </div>
                    </div>
                    <div style=""flex:auto; border-left: 1px solid;"">
                        <div>
                            <span style=""font-size:18px;"">Apartados creados</span>
                        </div>
                        <div>
                            <span style=""font-size:38px;"">
                                ");
#nullable restore
#line 72 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Home\Index.cshtml"
                           Write(Model.Sections);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVMO> Html { get; private set; }
    }
}
#pragma warning restore 1591
