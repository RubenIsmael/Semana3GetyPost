using Microsoft.AspNetCore.Mvc;
using Semana_3.Data;
using Semana_3.Models;

namespace Semana_3.Controllers
{
    public class EnfermeroController : Controller
    {
        private readonly Get_PostDbContext _context;

        public EnfermeroController(Get_PostDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var enfermeros = _context.Enfermeros.ToList();
            return View(enfermeros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EnfermeroModel enfermero)
        {
            if (ModelState.IsValid)
            {
                _context.Enfermeros.Add(enfermero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enfermero);
        }

        public IActionResult Edit(int id)
        {
            var enfermero = _context.Enfermeros.Find(id);
            if (enfermero == null)
            {
                return NotFound();
            }
            return View(enfermero);
        }

        [HttpPost]
        public IActionResult Edit(EnfermeroModel enfermero)
        {
            if (ModelState.IsValid)
            {
         
                var enfermeroExistente = _context.Enfermeros.Find(enfermero.IdEnfermero);
                if (enfermeroExistente == null)
                {
                    return NotFound();
                }

            
                enfermeroExistente.Nombre = enfermero.Nombre;
                enfermeroExistente.Apellido = enfermero.Apellido;
                enfermeroExistente.Especialidad = enfermero.Especialidad;
                enfermeroExistente.Telefono = enfermero.Telefono;

              
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enfermero);
        }

        public IActionResult Delete(int id)
        {
            var enfermero = _context.Enfermeros.Find(id);
            if (enfermero == null)
            {
                return NotFound();
            }
            return View(enfermero);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var enfermero = _context.Enfermeros.Find(id);
            if (enfermero != null)
            {
                _context.Enfermeros.Remove(enfermero);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}