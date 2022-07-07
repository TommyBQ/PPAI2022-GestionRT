using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class ModeloService : IGenericService<Modelo>
    {
        private static ModeloService _instance;
        private static List<Modelo> _modelos;

        public static ModeloService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModeloService();
                }
                return _instance;
            }
        }

        public List<Modelo> Delete(int id)
        {
            try
            {
                _modelos.RemoveAll(x => x.Id == id);
                return _modelos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró modelo con ese ID.");
            }
        }

        public List<Modelo> GetAll()
        {
            if (_modelos == null) _modelos = new List<Modelo>();
            return _modelos;
        }

        public Modelo GetById(int id)
        {
            try
            {
                return _modelos.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró modelo con ese ID.");
            }
        }

        public Modelo GetByName(string name)
        {
            try
            {
                return _modelos.Where(x => x.Nombre == name).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró modelo con ese nombre.");
            }
        }

        public List<Modelo> Insert(Modelo entity)
        {
            try
            {
                if (_instance == null) _instance = new ModeloService();
                if (_modelos == null) _modelos = new List<Modelo>();
                _modelos.Add(entity);
                return _modelos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar modelo.");
            }
        }

        public List<Modelo> Update(Modelo entity)
        {
            try
            {
                _modelos.RemoveAll(x => x == entity);
                _modelos.Add(entity);
                return _modelos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar modelo.");
            }
        }
    }
}
