using Microsoft.AspNetCore.Mvc;
using service_desk.Repositorio;

namespace service_desk.Controllers
{
    public class GLPIController : Controller
    {
        private readonly GLPI _glpi;

        public GLPIController(GLPI glpi)
        {
            _glpi = glpi;
        }

        public IActionResult Index()
        {
            _glpi.RecuperarSessionToken();
            _glpi.ObterDadosUsuarioPelaMatricula();
            _glpi.ObterDadosIdChamado();
            _glpi.ObterChamadosPorUsuario();
            _glpi.ObterAcompanhamentosDoChamado();
            _glpi.ObterSolucaoDoChamado();
            _glpi.ObterSatisfacaoDoChamado();
            return RedirectToAction("Index", "Home");
        }
    }
}
