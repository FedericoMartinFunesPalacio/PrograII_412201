namespace Problema2_7_412201_IngIndirecta.Models.Repositories
{
    public interface IRepository
    {
        void Create(Servicios servicios);
        void Update(Servicios servicios);
        void Delete(int id);
        List<Servicios> GetAll();
        Servicios GetById(int id);

    }
}
