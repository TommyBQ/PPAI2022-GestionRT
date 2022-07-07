using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class MantenimientoService : IGenericService<Mantenimiento>
    {
        private static MantenimientoService _instance;
        private static List<Mantenimiento> _mantenimientos;

        public static MantenimientoService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MantenimientoService();
                }
                return _instance;
            }
        }

        public List<Mantenimiento> Delete(int id)
        {
            try
            {
                _mantenimientos.RemoveAll(x => x.Id == id);
                return _mantenimientos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró mantenimiento con ese ID.");
            }
        }

        public List<Mantenimiento> GetAll()
        {
            if (_mantenimientos == null) _mantenimientos = new List<Mantenimiento>();
            return _mantenimientos;
        }

        public Mantenimiento GetById(int id)
        {
            try
            {
                return _mantenimientos.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró mantenimiento con ese ID.");
            }
        }

        public List<Mantenimiento> Insert(Mantenimiento entity)
        {
            try
            {
                if (_instance == null) _instance = new MantenimientoService();
                if (_mantenimientos == null) _mantenimientos = new List<Mantenimiento>();
                _mantenimientos.Add(entity);
                return _mantenimientos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar mantenimiento.");
            }
        }

        public List<Mantenimiento> Update(Mantenimiento entity)
        {
            try
            {
                _mantenimientos.RemoveAll(x => x == entity);
                _mantenimientos.Add(entity);
                return _mantenimientos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar mantenimiento.");
            }
        }
    }
}
