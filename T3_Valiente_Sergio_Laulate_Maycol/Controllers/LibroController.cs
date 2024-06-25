using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using T3_Valiente_Sergio_Laulate_Maycol.Datos;
using T3_Valiente_Sergio_Laulate_Maycol.Models;

namespace T3_Valiente_Sergio_Laulate_Maycol.Controllers
{
    [Authorize]
    public class LibroController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LibroController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.libro;
            return View(lista);
        }

        [Authorize]
        //Get Agregar
        public IActionResult Agregar()
        {
            return View();
        }

        //Post Agregar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Agregar(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.libro.Add(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }

        [Authorize]
        //Get Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.libro.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.libro.Update(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }

        [Authorize]
        //Get Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.libro.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Libro libro)
        {
            if (libro == null)
            {
                return NotFound();
            }
            _db.libro.Remove(libro);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
