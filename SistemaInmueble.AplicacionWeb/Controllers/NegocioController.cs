using Microsoft.AspNetCore.Mvc;

namespace SistemaInmueble.AplicacionWeb.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
