using Microsoft.AspNetCore.Mvc;

namespace SistemaInmueble.AplicacionWeb.Controllers
{
    public class ReporteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
