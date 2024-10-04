
namespace Problema2_7_412201_IngIndirecta.Models.Repositories
{
    public class RepositoryServicios : IRepositoryServicios
    {
        private Problema2_7Context _context;

        public RepositoryServicios(Problema2_7Context context)
        {
            _context = context;
        }

        public void Create(Servicios servicios)
        {
            _context.Servicios.Add(servicios);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = GetById(id);
            _context.Remove(delete);
            _context.SaveChanges();
        }

        public List<Servicios> GetAll()
        {
            return _context.Servicios.ToList();
        }

        public Servicios? GetById(int id)
        {
            return _context.Servicios.Find(id);
        }

        public void Update(Servicios servicios)
        {
            if(servicios != null) 
            {
                _context.Update(servicios);
                _context.SaveChanges();
            }
        }
    }
}
