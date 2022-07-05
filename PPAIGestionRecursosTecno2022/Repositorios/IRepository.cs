using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Repositorios
{
    public interface IRepository
    {
        Task<Usuario> GetById(int id);
        Task<Usuario> GetByName(string name);
        Task<IEnumerable<Usuario>> GetAll();
        Task Create(Usuario entity);
        Task Update(Usuario entity);
        Task Delete(int id);
    }
}
