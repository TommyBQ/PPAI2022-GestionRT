using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class AsignacionResponsableTecnicoRTService : IGenericService<AsignacionResponsableTecnicoRT>
    {
        private static AsignacionResponsableTecnicoRTService _instance;
        private static List<AsignacionResponsableTecnicoRT> _asignacionesResponsableTecnicoRTs;

        public static AsignacionResponsableTecnicoRTService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AsignacionResponsableTecnicoRTService();
                }
                return _instance;
            }
        }

        public List<AsignacionResponsableTecnicoRT> Delete(int id)
        {
            try
            {
                _asignacionesResponsableTecnicoRTs.RemoveAll(x => x.Id == id);
                return _asignacionesResponsableTecnicoRTs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró asignacionResponsableTecnicoRT con ese ID.");
            }
        }

        public List<AsignacionResponsableTecnicoRT> GetAll()
        {
            if (_asignacionesResponsableTecnicoRTs == null) _asignacionesResponsableTecnicoRTs = new List<AsignacionResponsableTecnicoRT>();
            return _asignacionesResponsableTecnicoRTs;
        }

        public AsignacionResponsableTecnicoRT GetById(int id)
        {
            try
            {
                return _asignacionesResponsableTecnicoRTs.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró asignacionResponsableTecnicoRT con ese ID.");
            }
        }

        public List<AsignacionResponsableTecnicoRT> Insert(AsignacionResponsableTecnicoRT entity)
        {
            try
            {
                if (_instance == null) _instance = new AsignacionResponsableTecnicoRTService();
                if (_asignacionesResponsableTecnicoRTs == null) _asignacionesResponsableTecnicoRTs = new List<AsignacionResponsableTecnicoRT>();
                _asignacionesResponsableTecnicoRTs.Add(entity);
                return _asignacionesResponsableTecnicoRTs;
            }
            catch (Exception)
            {
                throw new Exception("No se pudo agregar AsignacionResponsableTecnicoRT.");
            }
        }

        public List<AsignacionResponsableTecnicoRT> Update(AsignacionResponsableTecnicoRT entity)
        {
            try
            {
                _asignacionesResponsableTecnicoRTs.RemoveAll(x => x == entity);
                _asignacionesResponsableTecnicoRTs.Add(entity);
                return _asignacionesResponsableTecnicoRTs;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar asignacionResponsableTecnicoRT.");
            }
        }
    }
}
