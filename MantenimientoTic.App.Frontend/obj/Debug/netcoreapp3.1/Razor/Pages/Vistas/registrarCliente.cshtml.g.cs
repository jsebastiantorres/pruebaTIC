#pragma checksum "C:\Users\jseba\Documents\ProyectoMantenimientoTic\MantenimientoTic.App\MantenimientoTic.App.Frontend\Pages\Vistas\registrarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79e8df9381624be46df6a5001c0ded5de1493b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MantenimientoTic.App.Frontend.Pages.Vistas.Pages_Vistas_registrarCliente), @"mvc.1.0.razor-page", @"/Pages/Vistas/registrarCliente.cshtml")]
namespace MantenimientoTic.App.Frontend.Pages.Vistas
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
#line 1 "C:\Users\jseba\Documents\ProyectoMantenimientoTic\MantenimientoTic.App\MantenimientoTic.App.Frontend\Pages\_ViewImports.cshtml"
using MantenimientoTic.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e8df9381624be46df6a5001c0ded5de1493b98", @"/Pages/Vistas/registrarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed3c43129c507ef9c636068447d91efebe58042", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vistas_registrarCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h3");
            BeginWriteAttribute("class", " class=\"", 116, "\"", 124, 0);
            EndWriteAttribute();
            WriteLiteral(">Registro de cliente</h3>\r\n    <br>\r\n    <!--<p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">Listado actual de clientes</a>.</p>-->\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e8df9381624be46df6a5001c0ded5de1493b983992", async() => {
                WriteLiteral("\r\n        <div class=\"form-group col-md-8\">\r\n");
                WriteLiteral("            <input type=\"text\" class=\"form-control\" id=\"Nombre\" aria-describedby=\"nombre\"\r\n                placeholder=\"Nombre\">\r\n");
                WriteLiteral("        </div>\r\n        <div class=\"form-group col-md-8\">\r\n");
                WriteLiteral("            <input type=\"text\" class=\"form-control\" id=\"Apellido\" aria-describedby=\"apellido\"\r\n                placeholder=\"Apellido\">\r\n");
                WriteLiteral("        </div>\r\n        <div class=\"form-group col-md-8\">\r\n");
                WriteLiteral("            <input type=\"email\" class=\"form-control\" id=\"Email\" aria-describedby=\"emailHelp\"\r\n                placeholder=\"Correo electronico\">\r\n");
                WriteLiteral("        </div>\r\n        <div class=\"form-group col-md-8\">\r\n");
                WriteLiteral("            <input type=\"text\" class=\"form-control\" id=\"Direccion\" aria-describedby=\"direccion\"\r\n                placeholder=\"Dirección\">\r\n");
                WriteLiteral("        </div>\r\n        <div class=\"form-group col-md-8\">\r\n");
                WriteLiteral("            <input type=\"text\" class=\"form-control\" id=\"Telefono\" aria-describedby=\"telefono\"\r\n                placeholder=\"Teléfono\">\r\n");
                WriteLiteral("        </div>\r\n        <div class=\"form-group col-md-8\">\r\n            <button type=\"submit\" class=\"btn btn-success \">Registrar Cliente</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MantenimientoTic.App.Frontend.Pages.registrarClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MantenimientoTic.App.Frontend.Pages.registrarClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MantenimientoTic.App.Frontend.Pages.registrarClienteModel>)PageContext?.ViewData;
        public MantenimientoTic.App.Frontend.Pages.registrarClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591