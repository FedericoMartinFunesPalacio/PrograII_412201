using proyectoPractico02.Models;

namespace proyectoPractico02.Data
{
    public interface IAplication
    {
        List<Articulos> TraerTodos();
        List<Articulos> TraerPorID(int id);
        bool Guardar(Articulos oArticulo);
        bool Borrar(int id);
        bool Actualizar(Articulos oArticulo);
    }
}
