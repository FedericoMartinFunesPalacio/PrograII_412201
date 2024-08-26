using PilasNet_412201.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasNet_412201.Clases
{
    public class Colas : IColeccion
    {
        //ATRIBUTOS
        private List<Object> lista;
        int posicion;

        //PROPIEDADES
        public List<Object> Lista { get { return lista; } set { lista = value; } }

        //CONSTRUCTOR
        public Colas()
        {
            Lista= new List<Object>();
            int posicion = 0;
        }

        //METODOS
        public bool Añadir(object objeto)
        {
            Lista.Add(objeto);

            return true;
        }

        public bool EstaVacia()
        {
            if (Lista.Count == 0)
            {
                return true;
            }
            return false;
        }

        public string Extraer()
        {
            object objeto = Lista[posicion];
            Lista.RemoveAt(posicion);
            return objeto.ToString();
        }

        public string Primero()
        {
            object objeto = Lista[posicion];

            return objeto.ToString();
        }
    }
}
