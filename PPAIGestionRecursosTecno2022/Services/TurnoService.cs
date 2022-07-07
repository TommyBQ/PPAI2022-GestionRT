using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Services
{
    public class TurnoService : IGenericService<Turno>
    {
        private static TurnoService _instance;
        private static List<Turno> _turnos;

        public static TurnoService GetInstance
        {
            get
            {
                if (_instance == null) _instance = new TurnoService();
                return _instance;
            }
        }

        public List<Turno> Delete(int id)
        {
            try
            {
                _turnos.RemoveAll(x => x.IdTurno == id);
                return _turnos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró el turno con ese ID.");
            }
        }

        public List<Turno> GetAll()
        {
            if (_turnos == null) _turnos = new List<Turno>();
            return _turnos;
        }

        public Turno GetById(int id)
        {
            try
            {
                return _turnos.Where(x => x.IdTurno == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró turno con ese ID.");
            }
        }

        public List<Turno> Insert(Turno entity)
        {
            try
            {
                if (_instance == null)
                {
                    _instance = new TurnoService();
                }
                if (_turnos == null)
                {
                    _turnos = new List<Turno>();
                }
                _turnos.Add(entity);
                return _turnos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pude insertar turno.");
            }
        }

        public List<Turno> Update(Turno entity)
        {
            try
            {
                _turnos.RemoveAll(x => x == entity);
                _turnos.Add(entity);
                return _turnos;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar turno.");
            }
        }
    }
}
