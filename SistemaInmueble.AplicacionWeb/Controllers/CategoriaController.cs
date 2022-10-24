using Microsoft.AspNetCore.Mvc;

namespace SistemaInmueble.AplicacionWeb.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
