namespace PPAIGestionRecursosTecno2022.Models
{
    public class CambioEstadoTurno
    {
        private int _id;
        private DateTime _fechaHoraDesde;
        private DateTime? _fechaHoraHasta;
        private Estado _estado;

        public int Id { get { return _id; } }
        public DateTime FechaHoraDesde { get { return this._fechaHoraDesde; }  }
        public DateTime? FechaHoraHasta { get { return this._fechaHoraDesde; } }
        public Estado Estado { get { return this._estado; } }

        public CambioEstadoTurno(int id, DateTime fechaHoraDesde, DateTime? fechaHoraHasta, Estado estado)
        {
            _id = id;
            _fechaHoraDesde = fechaHoraDesde;
            _fechaHoraHasta = fechaHoraHasta;
            _estado = estado;
        }

        public int getId()
        {
            return Id;
        }
        public DateTime getFechaHoraDesde()
        {
            return FechaHoraDesde;
        }
        public DateTime? getFechaHoraHasta()
        {
            return FechaHoraHasta;
        }
        public Estado getEstado()
        {
            return Estado;
        }

        public void crear()
        {

        }

        public void sosEstadoActual()
        {

        }
    }
}
