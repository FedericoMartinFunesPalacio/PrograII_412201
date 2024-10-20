using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Dominio
{
    public class Articulos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int PrecioUnitario { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, PrecioUnitario: {PrecioUnitario}";
        }
    }
}
