using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class UsuarioService : IGenericService<Usuario>
    {
        private static UsuarioService _instance;
        private static List<Usuario> _usuarios;

        public static UsuarioService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsuarioService();
                }
                return _instance;
            }
        }

        public List<Usuario> Delete(int id)
        {
            try
            {
                _usuarios.RemoveAll(x => x.Id_Usuario == id);
                return _usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró usuario con ese ID.");
            }
        }

        public List<Usuario> GetAll()
        {
            if (_usuarios == null) _usuarios = new List<Usuario>();
            return _usuarios;
        }

        public Usuario GetById(int id)
        {
            try
            {
                return _usuarios.Where(x => x.Id_Usuario == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró usuario con ese ID.");
            }

        }

        public Usuario GetByName(string name)
        {
            try
            {
                return _usuarios.Where(x => x.NombreUsuario == name).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró usuario con ese nombre.");
            }
        }       
        
        public Usuario GetByNameAndPassword(string name, string password)
        {
            try
            {
                Usuario found = _usuarios.Where(x => x.NombreUsuario == name.Trim()).SingleOrDefault();
                if (found.Clave == password)
                {
                    return found;
                }
                else
                {
                    throw new Exception("Se ingresó contraseña incorrecta!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Se ingresó usuario incorrecto!");
            }
        }

        public List<Usuario> Insert(Usuario entity)
        {
            try
            {
                if (_instance == null)
                {
                    _instance = new UsuarioService();
                }
                if (_usuarios == null)
                {
                    _usuarios = new List<Usuario>();
                }
                _usuarios.Add(entity);
                return _usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró pudo agregar usuario.");
            }
        }

        public List<Usuario> Update(Usuario entity)
        {
            try
            {
                _usuarios.RemoveAll(x => x == entity);
                _usuarios.Add(entity);
                return _usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el usuario.");
            }
        }
    }
}
