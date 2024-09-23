using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Datos
{
    public class Parametros
    {
        //ATRIBUTOS Y PROPIEDADES
        public string Parametro { get; set; }
        public object Objeto { get; set; }
        //CONSTRUCTOR
        public Parametros(string parametro, object objeto)
        {
            Parametro = parametro;
            Objeto = objeto;
        }
    }
}
