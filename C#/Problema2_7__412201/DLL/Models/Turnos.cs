using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Problema2_7.Models
{
    [Table ("Turnos")]
    public class Turnos
    {
        //ATRIBUTOS Y PROPS
        [Key]
        public int IdTurno { get; set; }

        [Required]
        public DateOnly Fecha { get; set; }

        [Required]
        public TimeOnly Hora { get; set; }

        public string Cliente { get; set; }
    }
}
