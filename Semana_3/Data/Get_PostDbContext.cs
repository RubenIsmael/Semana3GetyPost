using Microsoft.EntityFrameworkCore;
using Semana_3.Models;

namespace Semana_3.Data
{
    public class Get_PostDbContext : DbContext
    {
        public Get_PostDbContext(DbContextOptions<Get_PostDbContext> options) : base(options)
        {
        }

        public DbSet<EnfermeroModel> Enfermeros { get; set; }
        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<HabitacionModel> Habitaciones { get; set; }
        public DbSet<TratamientoModel> Tratamientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}