using DLL.Data;
using Problema2_7.Models;

namespace Problema2_7.Repository
{
    public class Repository : IRepository
    {
        private WebDbContext _context;
        public Repository(WebDbContext context)
        {
            _context = context;
        }
        public bool Delete(int id)
        {
            var delete = _context.Servicios.Find(id);
            _context.Servicios.Remove(delete);
            if (_context.Servicios.Find(id) == null)
            {
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Servicios> GetAllServicios()
        {
            return _context.Servicios.ToList();
        }

        public Servicios? GetServicioByID(int Id)
        {
            return _context.Servicios.Find(Id);
        }

        public bool Save(Servicios servicio)
        {
            if(servicio != null)
            {
                if (servicio.IdServicio == 0)
                {
                    _context.Servicios.Add(servicio);
                    return true;
                }

            }
            return false;
        }

        public bool Update(Servicios servicio)
        {
            if(servicio != null)
            {
                _context.Servicios.Update(servicio);
                return true;
            }
            return false;
        }
    }
}
