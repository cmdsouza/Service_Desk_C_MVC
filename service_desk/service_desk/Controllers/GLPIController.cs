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
            //var teste = _glpi.RecuperarSessionToken().Result; // ####### Ok!
            //_glpi.CriarChamado(); // ####### Olhar o body, var objetivoEnviado
            var teste = _glpi.QuantidadeChamadosSolucionados(272).Result;
            //_glpi.ObterDadosIdChamado();
            //_glpi.ObterChamadosPorUsuario();
            //_glpi.ObterAcompanhamentosDoChamado();
            //_glpi.ObterSolucaoDoChamado();
            //_glpi.ObterSatisfacaoDoChamado();
            return View(teste);
        }
    }
}
