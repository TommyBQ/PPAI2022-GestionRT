namespace PPAIGestionRecursosTecno2022.Models
{
    public class Turno
    {
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraFin;
        private string _diaSemana;
        private DateTime _fechaGeneracion;
        private List<CambioEstadoTurno> _cambiosEstadoTurno;

        public DateTime FechaHoraInicio { get { return _fechaHoraInicio; } set { _fechaHoraInicio = value; } }
        public DateTime FechaHoraFin { get { return _fechaHoraFin; } set { _fechaHoraFin = value; } }
        public string DiaSemana { get { return _diaSemana; } set { _diaSemana = value; } }
        public DateTime FechaGeneracion { get { return _fechaGeneracion; } set { _fechaGeneracion = value; } }
        public List<CambioEstadoTurno> CambiosEstadoTurno { get { return _cambiosEstadoTurno; } set { _cambiosEstadoTurno = value; } }

        public Turno(DateTime fechaHoraInicio, DateTime fechaHoraFin, string diaSemana, DateTime fechaGeneracion)
        {
            FechaHoraInicio = fechaHoraInicio;
            FechaHoraFin = fechaHoraFin;
            DiaSemana = diaSemana;
            FechaGeneracion = fechaGeneracion;
            CambiosEstadoTurno = new List<CambioEstadoTurno>();
        }
        //public void getDatos()
        //{

        //}
        public DateTime getFechaInicio()
        {
            return FechaHoraInicio.Date;
        }
        public TimeSpan getHoraInicio()
        {
            return FechaHoraInicio.TimeOfDay;
        }
        public DateTime getFechaFin()
        {
            return FechaHoraFin.Date;
        }
        public TimeSpan getHoraFin()
        {
            return FechaHoraFin.TimeOfDay;
        }
        public string getDiaSemana()
        {
            return DiaSemana;
        }
        public DateTime getFechaGeneracion()
        {
            return FechaGeneracion;
        }
        public List<CambioEstadoTurno> getCambiosEstadoTurno()
        {
            return CambiosEstadoTurno;
        }
        public void setFechaHoraInicio(DateTime fechaHoraInicio)
        {
            FechaHoraInicio = fechaHoraInicio;
        }
        public void setFechaHoraFin(DateTime fechaHoraFin)
        {
            FechaHoraFin = fechaHoraFin;
        }
        public void setDiaSemana(string diaSemana)
        {
            DiaSemana = diaSemana;
        }
        public void setFechaGeneracion(DateTime fechaGeneracion)
        {
            FechaGeneracion = fechaGeneracion;
        }
        public void setEstado(List<CambioEstadoTurno> cambioEstados)
        {
            CambiosEstadoTurno = cambioEstados;
        }
        public void AgregarCambioEstadoTurno(CambioEstadoTurno cambioEstadoTurno)
        {
            CambiosEstadoTurno.Add(cambioEstadoTurno);
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
