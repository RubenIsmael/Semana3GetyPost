using Microsoft.AspNetCore.Mvc;
using Semana_3.Data;
using Semana_3.Models;

namespace Semana_3.Controllers
{
    public class TratamientoController : Controller
    {
        private readonly Get_PostDbContext _context;

        public TratamientoController(Get_PostDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tratamientos = _context.Tratamientos.ToList();
            return View(tratamientos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TratamientoModel tratamiento)
        {
            if (ModelState.IsValid)
            {
                _context.Tratamientos.Add(tratamiento);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tratamiento);
        }

        public IActionResult Edit(int id)
        {
            var tratamiento = _context.Tratamientos.Find(id);
            if (tratamiento == null)
            {
                return NotFound();
            }
            return View(tratamiento);
        }

        [HttpPost]
        public IActionResult Edit(TratamientoModel tratamiento)
        {
            if (ModelState.IsValid)
            {
                _context.Tratamientos.Update(tratamiento);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tratamiento);
        }

        public IActionResult Delete(int id)
        {
            var tratamiento = _context.Tratamientos.Find(id);
            if (tratamiento == null)
            {
                return NotFound();
            }
            return View(tratamiento);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var tratamiento = _context.Tratamientos.Find(id);
            if (tratamiento != null)
            {
                _context.Tratamientos.Remove(tratamiento);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}