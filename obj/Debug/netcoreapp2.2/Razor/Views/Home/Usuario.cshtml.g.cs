#pragma checksum "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6697c379624cb7797f3089463317e623d0f9ef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Usuario), @"mvc.1.0.view", @"/Views/Home/Usuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Usuario.cshtml", typeof(AspNetCore.Views_Home_Usuario))]
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
#line 1 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\_ViewImports.cshtml"
using TMS_Web;

#line default
#line hidden
#line 2 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
using TMS_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6697c379624cb7797f3089463317e623d0f9ef2", @"/Views/Home/Usuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98404f578e310bb838823e8697a2201ca710606", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Usuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UsuarioModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
  
    ViewData["Title"] = "Administracion Usuarios";

#line default
#line hidden
            BeginContext(121, 78, true);
            WriteLiteral("\r\n<h2 style=\"text-align:left; padding:10px;\">Administracion de Usuarios</h2>\r\n");
            EndContext();
            BeginContext(277, 199, true);
            WriteLiteral("\r\n<table class=\"table table-hover\" id=\"tblUsuarios\" style=\"table-layout:fixed; width:100%; word-wrap:break-word;\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"display:none;\">\r\n                ");
            EndContext();
            BeginContext(477, 38, false);
#line 20 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(515, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(571, 41, false);
#line 23 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(612, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(745, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(780, 42, false);
#line 29 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
           Write(Html.DisplayNameFor(model => model.tipo_c));

#line default
#line hidden
            EndContext();
            BeginContext(822, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(878, 42, false);
#line 32 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
           Write(Html.DisplayNameFor(model => model.tipo_s));

#line default
#line hidden
            EndContext();
            BeginContext(920, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(976, 42, false);
#line 35 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
           Write(Html.DisplayNameFor(model => model.tipo_e));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 124, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Acción\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
          
            bool[] ckCliente = new bool[Model.Count()];
            bool[] ckProveedor = new bool[Model.Count()];
            bool[] ckEmpleados = new bool[Model.Count()];
            int index = 0;
        

#line default
#line hidden
            BeginContext(1368, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 49 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1417, 114, true);
            WriteLiteral("            <tr>\r\n                <td style=\"display:none;\">\r\n                    <span>\r\n                        ");
            EndContext();
            BeginContext(1532, 37, false);
#line 54 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                   Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 128, true);
            WriteLiteral("\r\n                    </span>\r\n                </td>\r\n                <td>\r\n                    <span>\r\n                        ");
            EndContext();
            BeginContext(1698, 40, false);
#line 59 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                   Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 59, true);
            WriteLiteral("\r\n                    </span>\r\n\r\n                </td>   \r\n");
            EndContext();
            BeginContext(1920, 110, true);
            WriteLiteral("                <td>\r\n                    <div class=\"custom-control custom-checkbox custom-control-inline\">\r\n");
            EndContext();
#line 68 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                          
                            ckCliente[index] = Convert.ToBoolean(item.tipo_c);
                        

#line default
#line hidden
            BeginContext(2165, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2190, 88, false);
#line 71 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                   Write(Html.CheckBoxFor(modelItem => ckCliente[index], new { @class = "custom-control-input" }));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2304, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6697c379624cb7797f3089463317e623d0f9ef29867", async() => {
                BeginContext(2368, 9, true);
                WriteLiteral("Habilitar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 72 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ckCliente[index]);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2385, 165, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </td>\r\n                <td>\r\n                    <div class=\"custom-control custom-checkbox custom-control-inline\">\r\n");
            EndContext();
#line 78 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                          
                            ckProveedor[index] = Convert.ToBoolean(item.tipo_s);
                        

#line default
#line hidden
            BeginContext(2687, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2712, 90, false);
#line 81 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                   Write(Html.CheckBoxFor(modelItem => ckProveedor[index], new { @class = "custom-control-input" }));

#line default
#line hidden
            EndContext();
            BeginContext(2802, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2828, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6697c379624cb7797f3089463317e623d0f9ef212703", async() => {
                BeginContext(2894, 9, true);
                WriteLiteral("Habilitar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 82 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ckProveedor[index]);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2911, 163, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    <div class=\"custom-control custom-checkbox custom-control-inline\">\r\n");
            EndContext();
#line 87 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                          
                            ckEmpleados[index] = Convert.ToBoolean(item.tipo_e);
                        

#line default
#line hidden
            BeginContext(3211, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3236, 90, false);
#line 90 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                   Write(Html.CheckBoxFor(modelItem => ckEmpleados[index], new { @class = "custom-control-input" }));

#line default
#line hidden
            EndContext();
            BeginContext(3326, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3352, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6697c379624cb7797f3089463317e623d0f9ef215538", async() => {
                BeginContext(3418, 9, true);
                WriteLiteral("Habilitar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 91 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ckEmpleados[index]);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3435, 99, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3534, "\"", 3659, 1);
#line 96 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
WriteAttributeValue("", 3541, Url.Action("RefreshUser", "Usuario", new { a1 = ckEmpleados[index], a2 = ckCliente[index], a3 = ckProveedor[index] }), 3541, 118, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3660, 204, true);
            WriteLiteral(" class=\"btn btn-outline-secondary\">\r\n                        <i class=\"fas fa-sync\">\r\n                            Actualizar\r\n                        </i>\r\n                    </a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3864, "\"", 3914, 3);
            WriteAttributeValue("", 3871, "javascript:generatePasswordForUser(", 3871, 35, true);
#line 101 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
WriteAttributeValue("", 3906, index, 3906, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 3912, ");", 3912, 2, true);
            EndWriteAttribute();
            BeginContext(3915, 211, true);
            WriteLiteral(" class=\"btn btn-outline-primary\">\r\n                        <i class=\"fas fa-key\">\r\n                            Enviar Contraseña\r\n                        </i>\r\n                    </a>\r\n                </td>\r\n\r\n");
            EndContext();
#line 108 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
                  
                    index++;
                

#line default
#line hidden
            BeginContext(4195, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(4477, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 117 "E:\Documentacion Trabajo\DELTA CARGO\Implementacion\TMS (Services y WebApp)\TMS Web\Views\Home\Usuario.cshtml"
        }

#line default
#line hidden
            BeginContext(4507, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UsuarioModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591