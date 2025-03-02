using System.ComponentModel.DataAnnotations;

namespace Semana_3.Models
{
    public class TratamientoModel
    {
        [Key] public int IdTratamiento { get; set; }
        public int IdPaciente { get; set; }
        public int IdEnfermero { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
