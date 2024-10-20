using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasNet_412201.Interfaces
{
    internal interface IColeccion
    {
        bool EstaVacia();
        string Extraer();
        string Primero();
        bool Añadir(object objeto);
    }
}
