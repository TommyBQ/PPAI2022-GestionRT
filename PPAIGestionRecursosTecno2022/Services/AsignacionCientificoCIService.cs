using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class AsignacionCientificoCIService : IGenericService<AsignacionCientificoCI>
    {
        private static AsignacionCientificoCIService _instance;
        private static List<AsignacionCientificoCI> _asignacionesCientificoCIs;

        public static AsignacionCientificoCIService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AsignacionCientificoCIService();
                }
                return _instance;
            }
        }

        public List<AsignacionCientificoCI> Delete(int id)
        {
            try
            {
                _asignacionesCientificoCIs.RemoveAll(x => x.Id == id);
                return _asignacionesCientificoCIs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró asignacionCientificoCI con ese ID.");
            }
        }

        public List<AsignacionCientificoCI> GetAll()
        {
            if (_asignacionesCientificoCIs == null) _asignacionesCientificoCIs = new List<AsignacionCientificoCI>();
            return _asignacionesCientificoCIs;
        }

        public AsignacionCientificoCI GetById(int id)
        {
            try
            {
                return _asignacionesCientificoCIs.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró asignacionCientificoCI con ese ID.");
            }
        }

        public List<AsignacionCientificoCI> Insert(AsignacionCientificoCI entity)
        {
            try
            {
                if (_instance == null) _instance = new AsignacionCientificoCIService();
                if (_asignacionesCientificoCIs == null) _asignacionesCientificoCIs = new List<AsignacionCientificoCI>();
                _asignacionesCientificoCIs.Add(entity);
                return _asignacionesCientificoCIs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró asignacionCientificoCI con ese ID.");
            }
        }

        public List<AsignacionCientificoCI> Update(AsignacionCientificoCI entity)
        {
            _asignacionesCientificoCIs.RemoveAll(x => x == entity);
            _asignacionesCientificoCIs.Add(entity);
            return _asignacionesCientificoCIs;
        }
    }
}
