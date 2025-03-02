using System.ComponentModel.DataAnnotations;

namespace Semana_3.Models
{
            public class PacienteModel
        {
        [Key] public int IdPaciente { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string Apellido { get; set; }

        [Range(0, 120, ErrorMessage = "La edad debe estar entre 0 y 120.")]
        public int Edad { get; set; }

        public int IdHabitacion { get; set; }
    }
    }