
namespace RepasoParcialCine.Models.Repository
{
    public class Repository : IRepository
    {
        private CineDbContext _context;

        public Repository(CineDbContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            var pelicula = Get(id);
            if (pelicula != null)
            {
                _context.Remove(pelicula);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Peliculas? Get(int id)
        {
            return _context.Peliculas.Find(id);
        }

        public List<Peliculas> GetAll()
        {
            List<Peliculas> ltsValida = new List<Peliculas>();
            var lts = _context.Peliculas.ToList();
            foreach (var item in lts)
            {
                
                Peliculas pelicula = new Peliculas();
                pelicula.Id = item.Id;
                pelicula.Anio = item.Anio;
                pelicula.Director = item.Director;
                pelicula.Titulo = item.Titulo;
                pelicula.Estreno = item.Estreno;
                pelicula.IdGenero = item.IdGenero;
                pelicula.IdGeneroNavigation = item.IdGeneroNavigation;
                if (pelicula.Estreno)
                {
                    ltsValida.Add(pelicula);
                }
            }
            return ltsValida;
        }

        public bool Save(Peliculas pelicula)
        {
            if(pelicula != null)
            {
                _context.Peliculas.Add(pelicula);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(int id)
        {
            var pelicula = Get(id);
            if (pelicula.Estreno)
            {
                pelicula.Estreno = false;
                _context.Update(pelicula);
                _context.SaveChanges();
                return true;
            }
            return false;
            
        }
    }
}
