namespace RepasoParcialCine.Models.Repository
{
    public interface IRepository
    {
        bool Save(Peliculas pelicula);
        bool Delete(int id);
        bool Update(int id);
        List<Peliculas> GetAllValidados();
        Peliculas Get(int id);
    }
}
