using proyectoPractico01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Datos.Articulos
{
    public interface IAplication
    {
        List<Dominio.Articulos> TraerTodos();
        Dominio.Articulos TraerPorID(int id);
        bool Guardar(Dominio.Articulos oArticulo);
        bool Borrar(int id);
        bool Actualizar(Dominio.Articulos oArticulo);
    }
}
