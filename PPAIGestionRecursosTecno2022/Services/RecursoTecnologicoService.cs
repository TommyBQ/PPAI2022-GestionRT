using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class RecursoTecnologicoService : IGenericService<RecursoTecnologico>
    {
        private static RecursoTecnologicoService _instance;
        private static List<RecursoTecnologico> _recursosTecnologicos;

        public static RecursoTecnologicoService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RecursoTecnologicoService();
                }
                return _instance;
            }
        }

        public List<RecursoTecnologico> Delete(int id)
        {
            try
            {
                _recursosTecnologicos.RemoveAll(x => x.NumeroRT == id);
                return _recursosTecnologicos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró recurso tecnológico con ese ID.");

            }
        }

        public List<RecursoTecnologico> GetAll()
        {
            if (_recursosTecnologicos == null) _recursosTecnologicos = new List<RecursoTecnologico>();
            return _recursosTecnologicos;
        }

        public RecursoTecnologico GetById(int id)
        {
            try
            {
                return _recursosTecnologicos.Where(x => x.NumeroRT == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró usuario con ese ID.");

            }
        }

        public RecursoTecnologico GetByName(string name)
        {
            try
            {
                return _recursosTecnologicos.Where(x => x.Nombre == name).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró usuario con ese nombre.");

            }
        }

        public List<RecursoTecnologico> Insert(RecursoTecnologico entity)
        {
            try
            {
                if (_instance == null) _instance = new RecursoTecnologicoService();
                if (_recursosTecnologicos == null) _recursosTecnologicos = new List<RecursoTecnologico>();
                _recursosTecnologicos.Add(entity);
                return _recursosTecnologicos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo insertar recurso tecnológico.");

            }
        }

        public List<RecursoTecnologico> Update(RecursoTecnologico entity)
        {
            try
            {
                _recursosTecnologicos.RemoveAll(x => x == entity);
                _recursosTecnologicos.Add(entity);
                return _recursosTecnologicos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar RT.");

            }
        }
    }
}
