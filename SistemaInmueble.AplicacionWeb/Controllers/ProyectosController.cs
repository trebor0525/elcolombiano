using Microsoft.AspNetCore.Mvc;

namespace SistemaInmueble.AplicacionWeb.Controllers
{
    public class ProyectosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
