using Microsoft.AspNetCore.Mvc;
using Semana_3.Data;
using Semana_3.Models;

namespace Semana_3.Controllers
{
    public class PacienteController : Controller
    {
        private readonly Get_PostDbContext _context;

        public PacienteController(Get_PostDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pacientes = _context.Pacientes.ToList();
            return View(pacientes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PacienteModel paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Pacientes.Add(paciente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paciente);
        }

        public IActionResult Edit(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        [HttpPost]
        public IActionResult Edit(PacienteModel paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Pacientes.Update(paciente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paciente);
        }

        public IActionResult Delete(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}