#pragma checksum "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea2fe46bb9456243acd6701ce9a4c63be14f556"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Consulta), @"mvc.1.0.view", @"/Views/Produto/Consulta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Consulta.cshtml", typeof(AspNetCore.Views_Produto_Consulta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea2fe46bb9456243acd6701ce9a4c63be14f556", @"/Views/Produto/Consulta.cshtml")]
    public class Views_Produto_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto.Presentation.Models.ProdutoConsultaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 50, true);
            WriteLiteral("\r\n<h4>Consulta de Produtos</h4>\r\n<hr/>\r\n\r\n<strong>");
            EndContext();
            BeginContext(211, 20, false);
#line 12 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(231, 409, true);
            WriteLiteral(@"</strong>

<table class=""table table-bordered table-striped table-hover"">
    <thead>
        <tr>
            <td>Código</td>
            <td>Nome do Produto</td>
            <td width=""120"">Preço</td>
            <td>Quantidade</td>
            <td width=""120"">Total</td>
            <td>Data de Cadastro</td>
            <td width=""180"">Operações</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
         foreach(var item in Model)
    {

#line default
#line hidden
            BeginContext(684, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(715, 14, false);
#line 30 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.IdProduto);

#line default
#line hidden
            EndContext();
            BeginContext(729, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(753, 9, false);
#line 31 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(762, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(786, 24, false);
#line 32 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Preco.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(810, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(834, 15, false);
#line 33 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(849, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(873, 24, false);
#line 34 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Total.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(897, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(921, 40, false);
#line 35 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(961, 43, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1042, 2);
            WriteAttributeValue("", 1011, "/produto/Edicao/", 1011, 16, true);
#line 37 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
WriteAttributeValue("", 1027, item.IdProduto, 1027, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1043, 104, true);
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                    Atualizar\r\n                </a>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1147, "\"", 1187, 2);
            WriteAttributeValue("", 1154, "/produto/Exclusao/", 1154, 18, true);
#line 40 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
WriteAttributeValue("", 1172, item.IdProduto, 1172, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1188, 118, true);
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                    Excluir\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
    }

#line default
#line hidden
            BeginContext(1313, 94, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"7\">QUantidade de Registros: ");
            EndContext();
            BeginContext(1408, 11, false);
#line 49 "C:\Fabio Santos\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
                                                Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 48, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto.Presentation.Models.ProdutoConsultaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
