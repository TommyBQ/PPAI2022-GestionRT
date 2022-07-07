using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class TipoRTService : IGenericService<TipoRT>
    {
        private static TipoRTService _instance;
        private static List<TipoRT> _tipoRTs;

        public static TipoRTService GetInstance
        {
            get
            {
                if (_instance == null) _instance = new TipoRTService();
                return _instance;
            }
        }

        public List<TipoRT> Delete(int id)
        {
            try
            {
                _tipoRTs.RemoveAll(x => x.Id == id);
                return _tipoRTs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró tipo de RT con ese ID.");
            }
        }

        public List<TipoRT> GetAll()
        {
            if (_tipoRTs == null) _tipoRTs = new List<TipoRT>();
            return _tipoRTs;
        }

        public TipoRT GetById(int id)
        {
            try
            {
                return _tipoRTs.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró tipo de RT con ese ID.");
            }
        }

        public TipoRT GetByName(string name)
        {
            try
            {
                return _tipoRTs.Where(x => x.Nombre == name).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró tipo de RT con ese nombre.");
            }
        }

        public List<TipoRT> Insert(TipoRT entity)
        {
            try
            {
                if (_tipoRTs == null) _tipoRTs = new List<TipoRT>();
                if (_instance == null) _instance = new TipoRTService();
                _tipoRTs.Add(entity);
                return _tipoRTs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar tipo de RT.");
            }
        }

        public List<TipoRT> Update(TipoRT entity)
        {
            try
            {
                _tipoRTs.RemoveAll(x => x == entity);
                _tipoRTs.Add(entity);
                return _tipoRTs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar tipo de RT.");
            }
        }
    }
}
