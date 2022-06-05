using Microsoft.AspNetCore.Mvc;

namespace service_desk.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
