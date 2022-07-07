using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class EstadoService : IGenericService<Estado>
    {
        private static EstadoService _instance;
        private static List<Estado> _estados;

        public static EstadoService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EstadoService();
                }
                return _instance;
            }
        }

        public List<Estado> Delete(int id)
        {
            try
            {
                _estados.RemoveAll(x => x.Id == id);
                return _estados;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró estado con ese ID.");
            }
        }

        public List<Estado> GetAll()
        {
            if (_estados == null) _estados = new List<Estado>();
            return _estados;
        }

        public Estado GetById(int id)
        {
            try
            {
                return _estados.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró estado con ese ID.");
            }
        }

        public Estado GetByName(string name)
        {
            try
            {
                return _estados.Where(x => x.Nombre == name).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró estado con ese ID.");
            }
        }

        public List<Estado> Insert(Estado entity)
        {
            try
            {
                if (_instance == null) _instance = new EstadoService();
                if (_estados == null) _estados = new List<Estado>();
                _estados.Add(entity);
                return _estados;
            }
            catch (Exception)
            {
                throw new Exception("No se pudo agregar estado.");
            }
        }

        public List<Estado> Update(Estado entity)
        {
            try
            {
                _estados.RemoveAll(x => x == entity);
                _estados.Add(entity);
                return _estados;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar estado.");
            }
        }
    }
}
