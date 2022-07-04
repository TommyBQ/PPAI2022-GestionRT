namespace PPAIGestionRecursosTecno2022.Models
{
    public class CambioEstadoRT
    {
        private int _id;
        private DateTime _fechaHoraDesde;
        private DateTime? _fechaHoraHasta;
        private Estado _estado;

        public int Id { get { return _id; } set { _id = value; } }
        public DateTime FechaHoraDesde { get { return this._fechaHoraDesde; } }
        public DateTime? FechaHoraHasta { get { return this._fechaHoraDesde; } }
        public Estado Estado { get { return this._estado; } }

        public CambioEstadoRT(int id, DateTime fechaHoraDesde, DateTime? fechaHoraHasta, Estado estado)
        {
            Id = id;
            _fechaHoraDesde = fechaHoraDesde;
            _fechaHoraHasta = fechaHoraHasta;
            _estado = estado;
        }

        public DateTime getFechaHoraDesde()
        {
            return FechaHoraDesde;
        }
        public int getId()
        {
            return Id;
        }
        public DateTime? getFechaHoraHasta()
        {
            return FechaHoraHasta;
        }
        public Estado getEstado()
        {
            return Estado;
        }

        public void sosEstadoActual()
        {

        }
    }
}
