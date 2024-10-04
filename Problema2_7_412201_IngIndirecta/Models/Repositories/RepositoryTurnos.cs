
namespace Problema2_7_412201_IngIndirecta.Models.Repositories
{
    public class RepositoryTurnos : IRepositoryTurnos
    {
        private Problema2_7Context _context;

        public RepositoryTurnos(Problema2_7Context context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var delete = GetById(id);
            _context.Remove(delete);
            _context.SaveChanges();
        }

        public List<Turnos>? GetAll()
        {
            return _context.Turnos.ToList();
        }

        public Turnos? GetById(int id)
        {
            return _context.Turnos.Find(id);
        }

        public void Save(Turnos turnos)
        {
            _context.Turnos.Add(turnos);
            _context.SaveChanges();
        }

        public void Update(Turnos turnos)
        {
            if (turnos != null)
            {
                _context.Update(turnos);
                _context.SaveChanges();
            }
        }
    }
}
