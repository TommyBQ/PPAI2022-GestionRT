using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class CambioEstadoRTService : IGenericService<CambioEstadoRT>
    {
        private static CambioEstadoRTService _instance;
        private static List<CambioEstadoRT> _cambiosEstadoRTs;

        public static CambioEstadoRTService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CambioEstadoRTService();
                }
                return _instance;
            }
        }

        public List<CambioEstadoRT> Delete(int id)
        {
            try
            {
                _cambiosEstadoRTs.RemoveAll(x => x.Id == id);
                return _cambiosEstadoRTs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró cambioEstadoRT con ese ID.");
            }
        }

        public List<CambioEstadoRT> GetAll()
        {
            if (_cambiosEstadoRTs == null) _cambiosEstadoRTs = new List<CambioEstadoRT>();
            return _cambiosEstadoRTs;
        }

        public CambioEstadoRT GetById(int id)
        {
            try
            {
                return _cambiosEstadoRTs.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró cambioEstadoRT con ese ID.");
            }

        }
        public List<CambioEstadoRT> Insert(CambioEstadoRT entity)
        {
            try
            {
                if (_instance == null) _instance = new CambioEstadoRTService();
                if (_cambiosEstadoRTs == null) _cambiosEstadoRTs = new List<CambioEstadoRT>();
                _cambiosEstadoRTs.Add(entity);
                return _cambiosEstadoRTs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar cambioEstadoRT.");
            }
        }

        public List<CambioEstadoRT> Update(CambioEstadoRT entity)
        {
            try
            {
                _cambiosEstadoRTs.RemoveAll(x => x == entity);
                _cambiosEstadoRTs.Add(entity);
                return _cambiosEstadoRTs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar cambioEstadoRT.");
            }
        }
    }
}
