using System.ComponentModel.DataAnnotations;

namespace Semana_3.Models
{          public class HabitacionModel
        {
        [Key] public int IdHabitacion { get; set; }
        [Required(ErrorMessage = "El número de habitación es obligatorio.")]
        public string NumeroHabitacion { get; set; }

        public string Tipo { get; set; }

        public string Estado { get; set; }
    }
    }