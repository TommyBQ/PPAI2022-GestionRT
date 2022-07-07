namespace PPAIGestionRecursosTecno2022.Models
{
    public class Turno
    {
        private int _idTurno;
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraFin;
        private string _diaSemana;
        private DateTime _fechaGeneracion;
        private List<CambioEstadoTurno> _cambiosEstadoTurno;

        public int IdTurno{ get { return _idTurno; } }
        public DateTime FechaHoraInicio { get { return _fechaHoraInicio; } }
        public DateTime FechaHoraFin { get { return _fechaHoraFin; } }
        public string DiaSemana { get { return _diaSemana; }  }
        public DateTime FechaGeneracion { get { return _fechaGeneracion; }  }
        public List<CambioEstadoTurno> CambiosEstadoTurno { get { return _cambiosEstadoTurno; } }

        public Turno(int idTurno, DateTime fechaHoraInicio, DateTime fechaHoraFin, string diaSemana, DateTime fechaGeneracion, List<CambioEstadoTurno> cambiosEstadoTurno)
        {
            _idTurno = idTurno;
            _fechaHoraInicio = fechaHoraInicio;
            _fechaHoraFin = fechaHoraFin;
            _diaSemana = diaSemana;
            _fechaGeneracion = fechaGeneracion;
            _cambiosEstadoTurno = cambiosEstadoTurno;
        }

        public void AgregarCambioEstadoTurno(CambioEstadoTurno cambioEstadoTurno)
        {
            _cambiosEstadoTurno.Add(cambioEstadoTurno);
        }

        public void existenTurnos()
        {

        }
        public void verificarPlazoPendiente()
        {

        }
        public void dentroDelPlazo()
        {

        }
    }
}
