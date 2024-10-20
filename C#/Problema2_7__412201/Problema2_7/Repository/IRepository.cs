using Problema2_7.Models;

namespace Problema2_7.Repository
{
    public interface IRepository
    {
        List<Servicios> GetAllServicios();
        Servicios? GetServicioByID(int Id);
        bool Save(Servicios servicio);
        bool Delete(int id);
        bool Update(Servicios servicio);
    }
}
