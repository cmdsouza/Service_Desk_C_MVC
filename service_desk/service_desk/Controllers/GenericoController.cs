using Microsoft.AspNetCore.Mvc;
using service_desk.Helper;
using service_desk.Models;

namespace service_desk.Controllers
{
    public class GenericoController : Controller
    {
        private readonly UsuarioModel _usuario;

        public GenericoController(ISessao sessao)
        {
            _usuario = sessao.BuscarSessaoDoUsuario();
        }
    }
}
