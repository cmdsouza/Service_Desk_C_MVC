using Microsoft.AspNetCore.Mvc;

namespace service_desk.Controllers
{
    public class LayoutMestreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
