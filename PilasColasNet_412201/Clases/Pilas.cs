using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PilasNet_412201.Interfaces;

namespace PilasNet_412201.Clases
{
    public class Pilas : IColeccion
    {
        //ATRIBUTOS
        private object[] pilaObjetos;
        private int contadorObj;

        //PROPIEDADES
        public object[] PilaObjetos { get { return pilaObjetos; } set { pilaObjetos = value; } }
        public int ContadorObj { get { return contadorObj; } set { contadorObj = value; } }

        //CONSTRUCTOR
        public Pilas()
        {
            ContadorObj = 0;
            PilaObjetos = new object[100];
        }

        //METODOS

        public bool Añadir(object objeto)
        {
            for (int i = 0; i < PilaObjetos.Length; i++)
            {
                if (PilaObjetos[ContadorObj] == null)
                {
                    PilaObjetos[ContadorObj] = objeto;
                    ContadorObj++;
                    return true;
                }
            }
            return false;
        }

        public bool EstaVacia()
        {
            if (ContadorObj == 0)
            {
                return true;
            }
            return false;
        }

        public string Extraer()
        {
            ContadorObj--;
            string extraido;
            for (int i = 0; i < PilaObjetos.Length; i++)
            {
                if (PilaObjetos[ContadorObj] != null)
                {
                    extraido = PilaObjetos[ContadorObj].ToString();
                    PilaObjetos[ContadorObj] = null;

                    return "SE EXTRAJO EL PRIMER ELEMENTO: " + extraido + " OBJETOS ACTUALES: " + ContadorObj;
                }
            }
            return "NO SE PUDO EXTRAER EL PRIMER ELEMENTO " + "OBJETOS ACTUALES: " + ContadorObj;
        }

        public string Primero()
        {
            return "PRIMER OBJETO: " + PilaObjetos[ContadorObj - 1].ToString() + " OBJETOS ACTUALES: " + ContadorObj;
        }
    }
}
