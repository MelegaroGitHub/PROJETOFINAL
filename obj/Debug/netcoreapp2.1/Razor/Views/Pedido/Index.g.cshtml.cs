#pragma checksum "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1593e9a7a9d332211f59395632e3fcd662df2af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
#line 1 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\_ViewImports.cshtml"
using Hamburgueria_Tarde;

#line default
#line hidden
#line 2 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\_ViewImports.cshtml"
using Hamburgueria_Tarde.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1593e9a7a9d332211f59395632e3fcd662df2af0", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac6d330bca7c38ed999777249472e97826d572d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hamburgueria_Tarde.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Pedido/RegistrarPedido"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 3 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(125, 48, true);
            WriteLiteral("</header>\r\n\r\n<main>\r\n    <h2>Cadastro de Planos ");
            EndContext();
            BeginContext(174, 18, false);
#line 9 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
                      Write(Model.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(192, 11, true);
            WriteLiteral("</h2>\r\n    ");
            EndContext();
            BeginContext(203, 1435, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5387febd6514e85859eca57b14279af", async() => {
                BeginContext(255, 171, true);
                WriteLiteral("\r\n        <div>\r\n            <label for=\"nome\">Nome Completo</label>\r\n            <br />\r\n            <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 426, "\"", 453, 1);
#line 14 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 434, Model.Cliente.Nome, 434, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(454, 198, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"endereco\">Endereço</label>\r\n            <br />\r\n            <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"endereco\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 652, "\"", 683, 1);
#line 20 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 660, Model.Cliente.Endereco, 660, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(684, 182, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"telefone\">Telefone para contato</label>\r\n            <br />\r\n            <input id=\"telefone\" type=\"text\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 866, "\"", 897, 1);
#line 26 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 874, Model.Cliente.Telefone, 874, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(898, 159, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"email\">E-mail</label>\r\n            <br />\r\n            <input id=\"email\" type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1057, "\"", 1085, 1);
#line 32 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1065, Model.Cliente.Email, 1065, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1086, 201, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"double-field\">\r\n            <div>\r\n                <label for=\"planos\">Planos</label>\r\n                <select id=\"planos\" name=\"planos\">\r\n                    ");
                EndContext();
                BeginContext(1287, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c04b9dbf6ce4d2db4c162d3884585d2", async() => {
                    BeginContext(1322, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1340, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
                     foreach(var h in Model.Planos)
                    {

#line default
#line hidden
                BeginContext(1418, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1442, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db7087cbb0c43ecb058dbcb99159fc1", async() => {
                    BeginContext(1465, 6, false);
#line 42 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
                                         Write(h.Nome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 42 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
                          WriteLiteral(h.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1480, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\47218236812\Documents\ProjetoFinal\PROJETOFINAL\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1505, 126, true);
                WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n        <input type=\"submit\" value=\"Finalizar pedido!\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1638, 11, true);
            WriteLiteral("\'\'\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hamburgueria_Tarde.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591