#pragma checksum "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07fbc97a1e7247152707f892e254fc2122a4b2aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/Index.cshtml", typeof(AspNetCore.Views_Company_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07fbc97a1e7247152707f892e254fc2122a4b2aa", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98404f578e310bb838823e8697a2201ca710606", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Company\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07fbc97a1e7247152707f892e254fc2122a4b2aa4318", async() => {
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
            BeginContext(104, 391, true);
            WriteLiteral(@"
<h2>Tareas</h2>
<table class=""table table-hover"" id=""tblUsuarios"" style=""table-layout:fixed; width:100%; word-wrap:break-word;"">
    <thead>
        <tr>
            <th>
                Empresa
            </th>
            <th>
                Descripcion
            </th>
            <th>
                Accion
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Company\Index.cshtml"
         foreach (CompanyModel company in ViewBag.companyList)
        {

#line default
#line hidden
            BeginContext(570, 92, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <span>\r\n                        ");
            EndContext();
            BeginContext(663, 15, false);
#line 26 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Company\Index.cshtml"
                   Write(company.company);

#line default
#line hidden
            EndContext();
            BeginContext(678, 128, true);
            WriteLiteral("\r\n                    </span>\r\n                </td>\r\n                <td>\r\n                    <span>\r\n                        ");
            EndContext();
            BeginContext(807, 19, false);
#line 31 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Company\Index.cshtml"
                   Write(company.description);

#line default
#line hidden
            EndContext();
            BeginContext(826, 544, true);
            WriteLiteral(@"
                    </span>
                </td>
                <td>
                    <a id=""/"" href="""" class=""btn btn-outline-secondary"">
                        <i class=""fas fa-sync"">
                            Actualizar
                        </i>
                    </a>
                    <a href="""" class=""btn btn-outline-primary"">
                        <i class=""fas fa-key"">
                            Eliminar
                        </i>
                    </a>
                </td>
            </tr>
");
            EndContext();
#line 47 "C:\Users\hp\Desktop\DeltaCargo\Delta Cargo SRL\tms-web\Views\Company\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1381, 117, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n\r\n");
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