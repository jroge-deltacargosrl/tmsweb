#pragma checksum "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc1db64e3178f0a5562233d86dd9987838acd22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Truck_Index), @"mvc.1.0.view", @"/Views/Truck/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Truck/Index.cshtml", typeof(AspNetCore.Views_Truck_Index))]
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
#line 1 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\_ViewImports.cshtml"
using TMS_Web;

#line default
#line hidden
#line 2 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\_ViewImports.cshtml"
using TMS_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc1db64e3178f0a5562233d86dd9987838acd22", @"/Views/Truck/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98404f578e310bb838823e8697a2201ca710606", @"/Views/_ViewImports.cshtml")]
    public class Views_Truck_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/task.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9cc1db64e3178f0a5562233d86dd9987838acd224302", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(104, 401, true);
            WriteLiteral(@"
<h2>Tipos de camiones</h2>
<table class=""table table-hover"" id=""tblUsuarios"" style=""table-layout:fixed; width:100%; word-wrap:break-word;"">
    <thead>
        <tr>
            <th>
                Nombre
            </th>
            <th>
                Descripcion
            </th>
            <th>
                Acción
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
         foreach (TruckModel truck in ViewBag.truckList)
        {
            string nuevoId = truck.id.ToString();
            string nuevoHref = "truck-" + nuevoId;
            string idTxt = "txt-" + nuevoHref;
            string idInput = "input-" + nuevoHref;
            string idSave = "save-" + nuevoHref;
            string idCancel = "cancel-" + nuevoHref;
            string idDescription = "description-" + nuevoHref;
            string idTxt2 = "txt2-" + nuevoHref;

#line default
#line hidden
            BeginContext(995, 65, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=", 1060, "", 1070, 1);
#line 33 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
WriteAttributeValue("", 1064, idTxt, 1064, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1070, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1072, 10, false);
#line 33 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
                               Write(truck.type);

#line default
#line hidden
            EndContext();
            BeginContext(1082, 53, true);
            WriteLiteral("</span>\r\n                    <input class=\"inputEdit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1135, "", 1147, 1);
#line 34 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
WriteAttributeValue("", 1139, idInput, 1139, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1147, 103, true);
            WriteLiteral(" type=\"text\" hidden value=\"\" />\r\n                </td>\r\n                <td>\r\n                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=", 1250, "", 1261, 1);
#line 37 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
WriteAttributeValue("", 1254, idTxt2, 1254, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1261, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1263, 17, false);
#line 37 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
                                Write(truck.description);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 60, true);
            WriteLiteral("</span>\r\n                    <input class=\"inputDescription\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1340, "", 1358, 1);
#line 38 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
WriteAttributeValue("", 1344, idDescription, 1344, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1358, 100, true);
            WriteLiteral(" type=\"text\" hidden value=\"\" />\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("id", " id=", 1458, "", 1472, 1);
#line 41 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
WriteAttributeValue("", 1462, nuevoHref, 1462, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1472, 197, true);
            WriteLiteral(" class=\"btnEdit btn btn-primary\">\r\n                        <i class=\"fa fa-edit\">\r\n                            Editar\r\n                        </i>\r\n                    </a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("id", " id=", 1669, "", 1680, 1);
#line 46 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
WriteAttributeValue("", 1673, idSave, 1673, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1680, 218, true);
            WriteLiteral(" href=\"/Task/Update\" class=\"btnSave btn btn-warning\">\r\n                        <i class=\"fa fa-sync\">\r\n                            Guardar\r\n                        </i>\r\n                    </a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("id", " id=", 1898, "", 1911, 1);
#line 51 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
WriteAttributeValue("", 1902, idCancel, 1902, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1911, 431, true);
            WriteLiteral(@" class=""btnCancel btn btn-outline-secondary"">
                        <i class=""fas fa-sync"">
                            Cancelar
                        </i>
                    </a>
                    <a href="""" class=""btn btn-danger"">
                        <i class=""fa fa-times"">
                            Eliminar
                        </i>
                    </a>
                </td>
            </tr>
");
            EndContext();
#line 63 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2353, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 66 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
 if (ViewBag.response == 1)
{

#line default
#line hidden
            BeginContext(2409, 74, true);
            WriteLiteral("    <script>\r\n        alert(\"Actualizado correctamente\");\r\n    </script>\r\n");
            EndContext();
#line 71 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Truck\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2486, 2298, true);
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {
        $("".btnSave"").hide();
        $("".btnCancel"").hide();
        $("".btnEdit"").on(""click"", function () {
            $id = $(this).attr(""id"");
            $(""#txt-"" + $id).hide();
            $(this).hide();

            $(""#input-"" + $id).attr(""value"", $(""#txt-"" + $id).text());
            $(""#input-"" + $id).show();
            $(""#description-"" + $id).attr(""value"", $(""#txt2-"" + $id).text());
            $(""#description-"" + $id).show();
            $(""#save-"" + $id).show();
            $(""#cancel-"" + $id).show();

            $txtDescription = $(""#description-"" + $id).val();
            $txtEdit = $(""#input-"" + $id).val();
            $elements = $id.split(""-"");
            $(""#save-"" + $id).attr(""href"", ""/Truck/Update/"" + $elements[1] + ""/"" + $txtEdit + ""/"" + $txtDescription);
        });

        $("".btnCancel"").on(""click"", function () {
       ");
            WriteLiteral(@"     $idCancel = $(this).attr(""id"");
            $elements = $idCancel.split(""-"");
            $id = ""truck-"" + $elements[2];

            $(""#txt-"" + $id).show();
            $(""#"" + $id).show();

            $(""#input-"" + $id).hide();
            $(""#description-"" + $id).hide();
            $(""#save-"" + $id).hide();
            $(""#cancel-"" + $id).hide();
        });

        $("".inputEdit"").on(""keyup"", function () {
            $text = $(this).val();
            $elements = $(this).attr(""id"");
            $elements = $elements.split(""-"");
            $id = ""truck-"" + $elements[2];
            $txtDescription = $(""#description-"" + $id).val();
            console.log($text + $txtDescription);
            $(""#save-"" + $id).attr(""href"", ""/Truck/Update/"" + $elements[2] + ""/"" + $text + ""/"" + $txtDescription);
        });

        $("".inputDescription"").on(""keyup"", function () {
            $text = $(this).val();
            $elements = $(this).attr(""id"");
            $elements = $elemen");
            WriteLiteral("ts.split(\"-\");\r\n            $id = \"truck-\" + $elements[2];\r\n            $txtEdit = $(\"#input-\" + $id).val();\r\n            $(\"#save-\" + $id).attr(\"href\", \"/Truck/Update/\" + $elements[2] + \"/\" + $txtEdit + \"/\" + $text);\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
