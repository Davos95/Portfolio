#pragma checksum "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd31d223e3d08538f3ea22cf3b5db36536cb7302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sesion_Fotos), @"mvc.1.0.view", @"/Views/Sesion/Fotos.cshtml")]
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
#line 1 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
using ProyectoFotoCore3.Models.Entities.Sesion.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd31d223e3d08538f3ea22cf3b5db36536cb7302", @"/Views/Sesion/Fotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b19a2db015981e57f0b1065d345b4de929b17dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Sesion_Fotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SesionVMO>
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
  
    ViewData["Title"] = "Fotos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .grid-item {\r\n        width: 250px;\r\n    }\r\n</style>\r\n<div style=\"display:flex; justify-content:space-between;\">\r\n    <div>\r\n        <h2>");
#nullable restore
#line 16 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div>\r\n        <button class=\"btn waves-effect waves-darken green\" id=\"order\">Ordenar</button>\r\n    </div>\r\n</div>\r\n<input type=\"hidden\" id=\"IdSesion\"");
            BeginWriteAttribute("value", " value=\"", 501, "\"", 518, 1);
#nullable restore
#line 22 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
WriteAttributeValue("", 509, Model.Id, 509, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div class=\"row\" style=\"padding: 1rem 1.2rem;\">\r\n    <div class=\"col s12\">\r\n        <div class=\"grid\">\r\n");
#nullable restore
#line 26 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
             if (Model.Fotos.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
                 foreach (var foto in Model.Fotos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"grid-item\">\r\n                        <div class=\"image-card\"");
            BeginWriteAttribute("id", " id=\"", 843, "\"", 856, 1);
#nullable restore
#line 31 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
WriteAttributeValue("", 848, foto.Id, 848, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"image-card-content\">\r\n                                <img class=\"image-card-img\"");
            BeginWriteAttribute("src", " src=\"", 981, "\"", 1001, 1);
#nullable restore
#line 33 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
WriteAttributeValue("", 987, foto.UriAzure, 987, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <div class=\"foto-card-menu\">\r\n                                    <div class=\"icon-container width-50\">\r\n");
#nullable restore
#line 36 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
                                         if (Model.IdFotoPreview.HasValue && Model.IdFotoPreview.Value == foto.Id)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i");
            BeginWriteAttribute("id", " id=\"", 1349, "\"", 1370, 2);
            WriteAttributeValue("", 1354, "preview_", 1354, 8, true);
#nullable restore
#line 38 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
WriteAttributeValue("", 1362, foto.Id, 1362, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"material-icons icon-white\">star</i>\r\n");
#nullable restore
#line 39 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i");
            BeginWriteAttribute("id", " id=\"", 1594, "\"", 1615, 2);
            WriteAttributeValue("", 1599, "preview_", 1599, 8, true);
#nullable restore
#line 42 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
WriteAttributeValue("", 1607, foto.Id, 1607, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"material-icons icon-white\">star_border</i>\r\n");
#nullable restore
#line 43 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <i class=""material-icons icon-white"">check_box_outline_blank</i>
                                        <i class=""material-icons icon-red"">favorite_border</i>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 52 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>No hay fotos en esta sesión.</h1>\r\n                <h2>Intenta subir unas cuantas.</h2>\r\n");
#nullable restore
#line 58 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<!-- The Modal -->\r\n<div id=\"modalPreview\" class=\"modal-Preview\">\r\n    <span class=\"close\">&times;</span>\r\n    <img class=\"modal-content-Preview\" id=\"imagePreview\">\r\n    <div id=\"caption\"></div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd31d223e3d08538f3ea22cf3b5db36536cb730210197", async() => {
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

    <script>
        $(document).ready(function () {
            var $grid = $('.grid').masonry({
                // options...
                itemSelector: '.grid-item',
                columnWidth: 250
            });
            $grid.imagesLoaded().progress(function () {
                $grid.masonry('layout');
            });



            var origen;
            var flagImg = true;
            $("".image-card"").on(""dragover"", function (e) {
                e.preventDefault();
                //Recogemos el id del origen
                if (flagImg) {
                    origen = $(this).attr('id');
                    flagImg = false;
                }
            }).on(""drop"", function (e) {
                e.preventDefault();
                var destino = $(this).attr('id');

                console.log(origen);
                console.log(destino);

                /*Intercambio de imagenes*/
                var origenImg = $(""#"" + origen + "" img"").attr('src');
   ");
                WriteLiteral(@"             var destinoImg = $(""#"" + destino + "" img"").attr('src');

                $(""#"" + origen + "" img"").attr('src', destinoImg);
                $(""#"" + destino + "" img"").attr('src', origenImg);


                /* Intercambio de Ids */
                var origenIdImg = $(""#"" + origen).attr('id');
                var destinoIdImg = $(""#"" + destino).attr('id');

                $(""#"" + origen).attr('id', destinoIdImg);
                $(""#"" + destino).attr('id', origenIdImg);

                $grid.masonry('layout');

                flagImg = true;
            });



            $(""#order"").click(async function () {
                var array = new Array();

                $("".image-card"").each(function () {
                    array.push($(this).attr(""id""));
                });
                var idSesion = $(""#IdSesion"").val();

                var formData = new FormData();
                formData.append(""IdFotos"", array);
                formData.append(""IdSesion"", ");
                WriteLiteral("idSesion);\r\n                console.log(array);\r\n                var response = await $.ajax({\r\n                    url: \"");
#nullable restore
#line 139 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
                     Write(Url.Action("Ordenar","Foto"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    type: ""POST"",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (response) {
                        alert(""Success"");
                    }
                });

            });



            $(""[id^='preview_']"").click(async function () {

                var completeId = $(this).attr(""id"");
                var id = completeId.split(""_"")[1];

                var bool = await PreviewPhoto(id);
                if (bool) {
                    $(""[id^='preview_']"").text('star_border');
                    $(this).text('star');
                }

            });

        });

        async function PreviewPhoto(id) {
            var json = { ""id"": id };
            var bool = await SendForm(""");
#nullable restore
#line 170 "G:\Proyectos\ProyectoFotoCore3\Portfolio\ProyectoFotoCore3\Views\Sesion\Fotos.cshtml"
                                  Write(Url.Action("PreviewImage", "Foto"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"GET\", json);\r\n            return bool;\r\n\r\n        }\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SesionVMO> Html { get; private set; }
    }
}
#pragma warning restore 1591
