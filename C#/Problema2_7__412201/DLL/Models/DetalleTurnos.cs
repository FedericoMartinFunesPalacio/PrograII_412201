using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Problema2_7.Models
{
    [Table("DetalleTurnos")]
    public class DetalleTurnos
    {
        //ATRIBUTOS Y PROPS
        [Key]
        public int IdDetalle { get; set; }


        [ForeignKey("IdTurno")]
        public int IdTurno { get; set; }
        [Required]
        public Turnos Turno { get; set; }


        [ForeignKey("IdServicio")] 
        public int IdServicio { get;set; }
        [Required]
        public Servicios Servicio { get; set; }

        public string? Observaciones { get; set; }
    }
}
