using Microsoft.EntityFrameworkCore;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Repositorios
{
    public class UsuariosRepository : IRepository
    {
        private readonly GestionRTContext _context;

        public UsuariosRepository(GestionRTContext context)
        {
            _context = context;
        }

        public async Task Create(Usuario entity)
        {
            _context.Usuarios.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var user = new Usuario() { Id_Usuario = id }; //Puede dar error si no existe el objeto
            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public Task<Usuario> GetById(int id)
        {
            return _context.Usuarios.FirstOrDefaultAsync(u => u.Id_Usuario.Equals(id));
        }

        public Task<Usuario> GetByName(string name)
        {
            return _context.Usuarios.FirstOrDefaultAsync(u => u.NombreUsuario.Equals(name));
        }

        public async Task Update(Usuario entity)
        {
            _context.Usuarios.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
