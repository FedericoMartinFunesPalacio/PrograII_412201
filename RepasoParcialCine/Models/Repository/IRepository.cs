namespace RepasoParcialCine.Models.Repository
{
    public interface IRepository
    {
        bool Save(Peliculas pelicula);
        bool Delete(int id);
        bool Update(int id);
        List<Peliculas> GetAll();
        Peliculas Get(int id);
    }
}
