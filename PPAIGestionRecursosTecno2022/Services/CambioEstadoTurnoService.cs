using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class CambioEstadoTurnoService : IGenericService<CambioEstadoTurno>
    {
        private static CambioEstadoTurnoService _instance;
        private static List<CambioEstadoTurno> _cambiosEstadoTurnos;

        public static CambioEstadoTurnoService GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CambioEstadoTurnoService();
                }
                return _instance;
            }
        }

        public List<CambioEstadoTurno> Delete(int id)
        {
            try
            {
                _cambiosEstadoTurnos.RemoveAll(x => x.Id == id);
                return _cambiosEstadoTurnos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró cambioEstadoTurno con ese ID.");
            }
        }

        public List<CambioEstadoTurno> GetAll()
        {
            if (_cambiosEstadoTurnos == null) _cambiosEstadoTurnos = new List<CambioEstadoTurno>();
            return _cambiosEstadoTurnos;
        }

        public CambioEstadoTurno GetById(int id)
        {
            try
            {
                return _cambiosEstadoTurnos.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró cambioEstadoTurno con ese ID.");
            }
        }

        public List<CambioEstadoTurno> Insert(CambioEstadoTurno entity)
        {
            try
            {
                if (_instance == null) _instance = new CambioEstadoTurnoService();
                if (_cambiosEstadoTurnos == null) _cambiosEstadoTurnos = new List<CambioEstadoTurno>();
                _cambiosEstadoTurnos.Add(entity);
                return _cambiosEstadoTurnos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar cambioEstadoTurno.");
            }
        }

        public List<CambioEstadoTurno> Update(CambioEstadoTurno entity)
        {
            try
            {
                _cambiosEstadoTurnos.RemoveAll(x => x == entity);
                _cambiosEstadoTurnos.Add(entity);
                return _cambiosEstadoTurnos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar cambioEstadoTurno.");
            }
        }
    }
}
