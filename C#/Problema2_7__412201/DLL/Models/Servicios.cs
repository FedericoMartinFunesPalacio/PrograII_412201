using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Problema2_7.Models
{
    [Table ("Servicios")]
    public class Servicios
    {
        //ATRIBUTOS Y  PROPS
        [Key]
        public int IdServicio { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Costo { get; set; }

        [Required]
        public bool EnPromocion { get; set; }
    }
}
