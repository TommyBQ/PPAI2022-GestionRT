using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class SesionService : IGenericService<Sesion>
    {
        private static SesionService _instance;
        private static List<Sesion> _sesiones;

        public static SesionService GetInstance
        {
            get
            {
                if (_instance == null) _instance = new SesionService();
                return _instance;
            }
        }

        public List<Sesion> Delete(int id)
        {
            try
            {
                _sesiones.RemoveAll(x => x.Id == id);
                return _sesiones;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró sesion con ese ID.");

            }
        }

        public List<Sesion> GetAll()
        {
            if (_sesiones == null) _sesiones = new List<Sesion>();
            return _sesiones;
        }

        public Sesion GetById(int id)
        {
            try
            {
                return _sesiones.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró sesion con ese ID.");
            }
        }

        public List<Sesion> Insert(Sesion entity)
        {
            try
            {
                if (_instance == null) _instance = new SesionService();
                if (_sesiones == null) _sesiones = new List<Sesion>();
                _sesiones.Add(entity);
                return _sesiones;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró se pudo agregar sesión.");

            }
        }

        public List<Sesion> Update(Sesion entity)
        {
            try
            {
                _sesiones.Add(entity);
                return _sesiones;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar sesión.");
            }
        }
    }
}
