namespace Problema2_7_412201_IngIndirecta.Models.Repositories
{
    public interface IRepositoryTurnos
    {
        void Save(Turnos turnos);
        void Delete(int  id);
        void Update(Turnos turnos);
        List<Turnos>? GetAll();
        Turnos? GetById(int id);
    }
}
