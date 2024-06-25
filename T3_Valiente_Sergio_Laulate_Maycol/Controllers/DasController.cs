using Microsoft.AspNetCore.Mvc;

namespace T3_Valiente_Sergio_Laulate_Maycol.Controllers
{
    public class DasController : Controller
    {
        public IActionResult Diseño()
        {
            return View();
        }
        public IActionResult Arquitectura()
        {
            return View();
        }
    }
}
