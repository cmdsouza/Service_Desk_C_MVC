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
            return RedirectToAction("Index", "Home");
        }
    }
}
