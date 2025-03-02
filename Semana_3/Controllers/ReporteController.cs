using Microsoft.AspNetCore.Mvc;
using Semana_3.Data;

public class ReporteController : Controller
{
    private readonly Get_PostDbContext _context;

    public ReporteController(Get_PostDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var reportes = from t in _context.Tratamientos
                       join p in _context.Pacientes on t.IdPaciente equals p.IdPaciente
                       join e in _context.Enfermeros on t.IdEnfermero equals e.IdEnfermero
                       select new
                       {
                           PacienteNombre = p.Nombre,
                           PacienteApellido = p.Apellido,
                           EnfermeroNombre = e.Nombre,
                           EnfermeroApellido = e.Apellido,
                           t.Descripcion,
                           t.Fecha
                       };

        return View(reportes.ToList());
    }
}