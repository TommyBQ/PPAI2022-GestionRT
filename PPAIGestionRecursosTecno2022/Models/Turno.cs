namespace PPAIGestionRecursosTecno2022.Models
{
    public class Turno
    {
        private DateTime fechaHoraInicio { get; set; }
        private DateTime fechaHoraFin { get; set; }
        private string diaSemana { get; set; }
        private DateTime fechaGeneracion { get; set; }
        private List<CambioEstadoTurno> _cambioEstadoTurno { get; set; }

        public Turno(DateTime fechaHoraInicio, DateTime fechaHoraFin, string diaSemana, DateTime fechaGeneracion)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.diaSemana = diaSemana;
            this.fechaGeneracion = fechaGeneracion;
            _cambioEstadoTurno = new List<CambioEstadoTurno>();
        }

        public void AgregarCambioEstadoTurno(CambioEstadoTurno cambioEstadoTurno)
        {
            _cambioEstadoTurno.Add(cambioEstadoTurno);
        }

        public IReadOnlyCollection<CambioEstadoTurno> CambioEstadoTurno
        {
            get { return _cambioEstadoTurno.AsReadOnly(); }
        }

        public void existenTurnos()
        {

        }
        public void getDatos()
        {

        }
        public void getFecha()
        {

        }
        public void getHora()
        {

        }
        public void setEstado()
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
