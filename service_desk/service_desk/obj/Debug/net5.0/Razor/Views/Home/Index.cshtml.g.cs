#pragma checksum "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3573487a41b7acb10af96a8ad8d0c7013d1327a8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3573487a41b7acb10af96a8ad8d0c7013d1327a8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3ddd908c6c8bb456311f677e0e9d11f4ad8911", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApagarConfirmacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "P??gina Inicial";
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
#line 20 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                     if (DateTime.Now.Hour < 12)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<span>Bom dia!</span>\r\n");
#nullable restore
#line 23 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
					}
					else if (DateTime.Now.Hour < 17)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<span>Boa tarde!</span>\r\n");
#nullable restore
#line 27 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<span>Boa noite!</span>\r\n");
#nullable restore
#line 31 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
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
#line 52 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
         if (TempData["MensagemSucesso"] != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"alert alert-success\" role=\"alert\">\r\n\t\t\t\t");
#nullable restore
#line 55 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
           Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 57 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
         if (TempData["MensagemErro"] != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"alert alert-danger\" role=\"alert\">\r\n\t\t\t\t");
#nullable restore
#line 62 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
           Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 64 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
         if (TempData["teste"] != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"alert alert-danger\" role=\"alert\">\r\n\t\t\t\t");
#nullable restore
#line 69 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
           Write(TempData["teste"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 71 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
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
#line 86 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
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
#line 109 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
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
								<h5 class=""card-header"">Meus ??ltimos chamados</h5>
							</div>
						</div>

						<hr />
						");
#nullable restore
#line 135 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                   Write(TempData["listaChamados"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						<hr />

						<div class=""table-responsive text-nowrap"">
							<table class=""table table-striped"">
								<thead>
									<tr>
										<th scope=""col""><center>#</center></th>
										<th scope=""col"">T??tulo</th>
										<th scope=""col""><center>Status</center></th>
										<th scope=""col""><center>Data de Abertura</center></th>
										<th scope=""col""><center>??ltima Atualiza????o</center></th>
									</tr>
								</thead>
								<tbody class=""table-border-bottom-0"">
									<tr>
										<td>
											<center>
												");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3573487a41b7acb10af96a8ad8d0c7013d1327a813391", async() => {
                WriteLiteral("12345");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
											</center>
										</td>
										<td>Meu computador n??o liga!</td>
										<td>
											<center>
												<span class=""badge bg-label-primary"" style=""padding-top: 10px; padding-bottom: 10px; padding-left: 10px; padding-right: 12px;"">Primary</span>
											</center>
										</td>
										<td><center>05/06/2022 13:28:05</center></td>
										<td><center>05/06/2022 13:28:05</center></td>
									</tr>
									<tr>
										<td>
											<center>
												");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3573487a41b7acb10af96a8ad8d0c7013d1327a815857", async() => {
                WriteLiteral("67891");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
											</center>
										</td>
										<td>Permiss??o no e-TCEES</td>
										<td>
											<center>
												<span class=""badge bg-label-primary"" style=""padding-top: 10px; padding-bottom: 10px; padding-left: 10px; padding-right: 12px;"">Primary</span>
											</center>
										</td>
										<td><center>05/06/2022 14:18:05</center></td>
										<td><center>05/06/2022 14:58:05</center></td>
									</tr>
								</tbody>
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
			?? ");
#nullable restore
#line 193 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
         Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | <a href=\"https://github.com/cmdsouza/cmdsouza\">Desenvolvido por Carlos Matheus</a> | Token: ");
#nullable restore
#line 193 "C:\Users\Carlos Matheus\Desktop\TCC\Service_Desk_C_MVC\service_desk\service_desk\Views\Home\Index.cshtml"
                                                                                                                          Write(TempData["token"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t  </div>\r\n\t\t  <!-- Copyright -->\r\n\t\t</footer>\r\n\t\t<!-- Footer -->\r\n\r\n\t\t<div class=\"content-backdrop fade\"></div>\r\n\t\t<!-- / Layout page -->\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
