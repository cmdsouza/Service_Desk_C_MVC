#pragma checksum "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96150b714286a2d1a7ac6162233c7971b0543a99"
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
#nullable restore
#line 1 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
using static service_desk.Models.ChamadosUsuarioModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96150b714286a2d1a7ac6162233c7971b0543a99", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3ddd908c6c8bb456311f677e0e9d11f4ad8911", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Informacoes>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Página Inicial";
	Layout = "_Layout";

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

		<div class=""row"">
			<div class=""col-sm-7"">
				<h6 style=""color: #3A3A3A; font-weight: bold;"">
");
#nullable restore
#line 23 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                     if (DateTime.Now.Hour < 12)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<span>Bom dia!</span>\r\n");
#nullable restore
#line 26 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
					}
					else if (DateTime.Now.Hour < 17)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<span>Boa tarde!</span>\r\n");
#nullable restore
#line 30 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<span>Boa noite!</span>\r\n");
#nullable restore
#line 34 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				</h6>
			</div>
			<div class=""col text-end"">
				<p style=""color: #AFAFAF; font-size: 12px; "">50% dos chamados resolvidos</p>
			</div>
			<div class=""col col-lg-2"">
				<div class=""demo-vertical-spacing"" style=""margin-top:-7%;"">
					<div class=""progress"" style=""height: 8px;"">
						<div class=""progress-bar""
							 role=""progressbar""
							 style=""width: 50%""
							 aria-valuenow=""50""
							 aria-valuemin=""0""
							 aria-valuemax=""100""></div>
					</div>
				</div>
			</div>
		</div>

		<!-- Alertas de sucesso ou erro-->
");
#nullable restore
#line 55 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
         if (TempData["MensagemSucesso"] != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"alert alert-success\" role=\"alert\">\r\n\t\t\t\t");
#nullable restore
#line 58 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
           Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 60 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
         if (TempData["MensagemErro"] != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"alert alert-danger\" role=\"alert\">\r\n\t\t\t\t");
#nullable restore
#line 65 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
           Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 67 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
         if (TempData["teste"] != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"alert alert-danger\" role=\"alert\">\r\n\t\t\t\t");
#nullable restore
#line 72 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
           Write(TempData["teste"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 74 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	</div>

	<!-- Content wrapper -->
	<div class=""content-wrapper"" style=""margin-top:-4%;"">
		<!-- Content -->

		<div class=""container-xxl flex-grow-1 container-p-y"">
			<div class=""row"">
				<!-- Card 01 -->
				<div class=""col-lg-6 mb-4 order-0"">
					<div class=""card"" style=""background-image:url('../assets/img/card01-fundo.svg'); background-repeat: no-repeat;  background-size: cover; background-color: #1B5F9D;"">
						<div class=""d-flex align-items-center row"">
							<div class=""col-sm-6"">
								<div class=""card-body"" style=""color:white; margin-top:-5%;;"">
									<span style=""font-size: 90px; font-weight: bold; margin-left:5%;"">");
#nullable restore
#line 89 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                                                                 Write(TempData["quantChamados"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span><br>
									<div style=""margin-top:-10%;"">
										<span style=""font-size: 20px; margin-left:5%;"">Chamados Abertos</span>
									</div>
								</div>
							</div>
							<div class=""col-sm-6 text-center text-sm-left"">
								<div class=""card-body pb-0 "">
									<img src=""../assets/img/card01.svg""
										 alt=""View Badge User""
										 style=""margin-left:-15%;"" />
								</div>
							</div>
						</div>
					</div>
				</div>

				<!-- Card 02 -->
				<div class=""col-lg-6 mb-4 order-0"">
					<div class=""card"" style=""background-image:url('../assets/img/card02-fundo.svg'); background-repeat: no-repeat;  background-size: cover; background-color: #0077B2;"">
						<div class=""d-flex align-items-center row"">
							<div class=""col-sm-8"">
								<div class=""card-body"" style=""color:white; margin-top:-5%;;"">
									<span style=""font-size: 90px; font-weight: bold; margin-left:5%;"">");
#nullable restore
#line 112 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                                                                 Write(TempData["quantChamadosSolucionados"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span><br>
									<div style=""margin-top:-6%;"">
										<span style=""font-size: 20px; margin-left:5%;"">Chamados Solucionados</span>
									</div>
								</div>
							</div>
							<div class=""col-sm-4 text-center text-sm-left"">
								<div class=""card-body pb-0 "">
									<img src=""../assets/img/card02.svg""
										 alt=""View Badge User""
										 style=""margin-left:-35%; margin-top:8%;"" />
								</div>
							</div>
						</div>
					</div>
				</div>

				<div class=""col-lg-12 mb-4 order-0"">
					<div class=""card"">
						<div class=""row"">
							<div class=""col-sm"">
								<h5 class=""card-header"">Meus últimos chamados</h5>
							</div>
						</div>

						<div class=""table-responsive text-nowrap"">
							<table class=""table table-striped"">
								<thead>
									<tr>
										<th scope=""col""><center>#</center></th>
										<th scope=""col"">Título</th>
										<th scope=""col""><center>Status</center></th>
										<th scope=""col""><center>Data de Abertur");
            WriteLiteral("a</center></th>\r\n\t\t\t\t\t\t\t\t\t\t<th scope=\"col\"><center>Última Atualização</center></th>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t</thead>\r\n\t\t\t\t\t\t\t\t<tbody class=\"table-border-bottom-0\">\r\n\r\n");
#nullable restore
#line 150 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                     if (Model != null && Model.Any())
									{
										foreach (var chamado in Model)
										{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<center>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"#\" role=\"button\">");
#nullable restore
#line 158 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                                             Write(chamado.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</center>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 161 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                               Write(chamado.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<center>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n");
#nullable restore
#line 165 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                         if (chamado.status == 1)
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-primary\" style=\"padding:10px 12px 10px 10px;\">Novo</span>\r\n");
#nullable restore
#line 168 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
														}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 170 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                         if (chamado.status == 2)
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-secondary\" style=\"padding:10px 12px 10px 10px;\">Processando (atribuído)</span>\r\n");
#nullable restore
#line 173 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
														}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 175 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                         if (chamado.status == 3)
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-secondary\" style=\"padding:10px 12px 10px 10px;\">Processando (planejado)</span>\r\n");
#nullable restore
#line 178 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
														}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 180 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                         if (chamado.status == 4)
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-warning\" style=\"padding:10px 12px 10px 10px;\">Pendente</span>\r\n");
#nullable restore
#line 183 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
														}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 185 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                         if (chamado.status == 5)
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-info\" style=\"padding:10px 12px 10px 10px;\">Solucionado</span>\r\n");
#nullable restore
#line 188 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
														}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 190 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                         if (chamado.status == 6)
														{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-dark\" style=\"padding:10px 12px 10px 10px;\">Fechado</span>\r\n");
#nullable restore
#line 193 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
														}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</center>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<td><center>");
#nullable restore
#line 197 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                       Write(chamado.dataAbertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</center></td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<td><center>");
#nullable restore
#line 198 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                       Write(chamado.dataAtualizacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</center></td>\r\n\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 200 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
										}
									}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								</tbody>
							</table>
						</div>
					</div>
				</div>

			</div>
		</div>

		<!-- Footer -->
		<footer class=""text-center text-lg-start bg-light text-muted"">
			<!-- Copyright -->
			<div class=""text-center p-4"" style=""background-color: rgba(0, 0, 0, 0.05);"">
				© ");
#nullable restore
#line 215 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
             Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | <a href=\"https://github.com/cmdsouza/cmdsouza\">Desenvolvido por Carlos Matheus</a> | Token: ");
#nullable restore
#line 215 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                                                                                              Write(TempData["token"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<!-- Copyright -->\r\n\t\t</footer>\r\n\t\t<!-- Footer -->\r\n\r\n\t\t<div class=\"content-backdrop fade\"></div>\r\n\t\t<!-- / Layout page -->\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Informacoes>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
