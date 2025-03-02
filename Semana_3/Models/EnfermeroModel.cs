using System.ComponentModel.DataAnnotations;

namespace Semana_3.Models
{
    public class EnfermeroModel
    {
        [Key] public int IdEnfermero { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string Apellido { get; set; }

        public string Especialidad { get; set; }

        [Phone(ErrorMessage = "Número de teléfono no válido.")]
        public string Telefono { get; set; }
    }
}