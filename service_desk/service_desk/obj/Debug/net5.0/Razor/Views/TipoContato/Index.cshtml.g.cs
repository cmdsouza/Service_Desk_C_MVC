#pragma checksum "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3693e91101cee9e04975ca8718ca68b6e9d21d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoContato_Index), @"mvc.1.0.view", @"/Views/TipoContato/Index.cshtml")]
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
#line 1 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\_ViewImports.cshtml"
using service_desk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\_ViewImports.cshtml"
using service_desk.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3693e91101cee9e04975ca8718ca68b6e9d21d83", @"/Views/TipoContato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3ddd908c6c8bb456311f677e0e9d11f4ad8911", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TipoContato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TipoContatoModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TipoContato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Criar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-offset", new global::Microsoft.AspNetCore.Html.HtmlString("0,4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-html", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApagarConfirmacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Excluir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
  
	ViewData["Title"] = "Lista de Tipos de Contatos";
	Layout = "_LayoutAdministrador";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""layout-page"">
	<div class=""container-xxl container-p-y"">

		<div class=""layout-menu-toggle navbar-nav align-items-xl-center me-3 me-xl-0 d-xl-none"">
			<div class=""row"">
				<a class=""nav-item nav-link px-0 me-xl-4"" href=""javascript:void(0)"" style=""margin-left: 1.5%;"">
					<i class=""bx bx-menu bx-sm""></i>
				</a>
			</div>
		</div>
		<!-- Striped Rows -->
		<div class=""container"">
");
#nullable restore
#line 20 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
             if (TempData["MensagemSucesso"] != null)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"alert alert-success\" role=\"alert\">\r\n\t\t\t\t\t");
#nullable restore
#line 23 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
               Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 25 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
             if (TempData["MensagemErro"] != null)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"alert alert-danger\" role=\"alert\">\r\n\t\t\t\t\t");
#nullable restore
#line 30 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
               Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 32 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"card\">\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-sm\">\r\n\t\t\t\t\t\t<h5 class=\"card-header\">Lista de Tipos de Contatos</h5>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm text-end\" style=\"margin-top: 2%; margin-right: 3%;\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3693e91101cee9e04975ca8718ca68b6e9d21d8310434", async() => {
                WriteLiteral("Adicionar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
					</div>
				</div>
				<div class=""table-responsive text-nowrap"">
					<table class=""table table-striped"">
						<thead>
							<tr>
								<td><center>Ícone</center></td>
								<td>Descrição</td>
								<th scope=""col""><center>Última Atualização</center></th>
								<th scope=""col""><center>Ações</center></th>
							</tr>
						</thead>
						<tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 54 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                             if (Model != null && Model.Any())
							{
								foreach (TipoContatoModel tipoContato in Model)
								{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td><center><i");
            BeginWriteAttribute("class", " class=\'", 1763, "\'", 1789, 1);
#nullable restore
#line 60 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
WriteAttributeValue("", 1771, tipoContato.Icone, 1771, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></center></td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 61 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                                       Write(tipoContato.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<center>\r\n");
#nullable restore
#line 64 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                                                 if (tipoContato.DataAtualizacao == null)
												{
													

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                                               Write(tipoContato.DataCriacao);

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                                                                            
												}
												else
												{
													

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                                               Write(tipoContato.DataAtualizacao);

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                                                                                
												}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t</center>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<center>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3693e91101cee9e04975ca8718ca68b6e9d21d8315292", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\'bx bx-edit\' style=\"margin-top: -2%;\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                                             WriteLiteral(tipoContato.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3693e91101cee9e04975ca8718ca68b6e9d21d8318323", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\'bx bx-trash\' style=\"margin-top: -2%;\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
                                             WriteLiteral(tipoContato.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</center>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 101 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\TipoContato\Index.cshtml"
								}
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<!--/ Striped Rows -->\r\n\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TipoContatoModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
