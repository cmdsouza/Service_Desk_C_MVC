using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using service_desk.Models;
using System.Threading.Tasks;

namespace service_desk.ViewComponents
{
	public class MenuAdministrador : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

			if (string.IsNullOrEmpty(sessaoUsuario)) return null;

			UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

			return View(usuario);
		}
	}
}
