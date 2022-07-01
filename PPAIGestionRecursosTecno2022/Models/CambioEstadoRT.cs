namespace PPAIGestionRecursosTecno2022.Models
{
    public class CambioEstadoRT
    {
        private int _id;
        private DateTime _fechaHoraDesde;
        private DateTime? _fechaHoraHasta;
        private Estado _estado;

        public int Id { get { return _id; } set { _id = value; } }
        public DateTime FechaHoraDesde { get { return this._fechaHoraDesde; } set { setFechaHoraDesde(value); } }
        public DateTime? FechaHoraHasta { get { return this._fechaHoraDesde; } set { setFechaHoraHasta(value); } }
        public Estado Estado { get { return this._estado; } set { setEstado(value); } }


        public CambioEstadoRT(DateTime fechaHoraDesde, DateTime? fechaHoraHasta, Estado estado)
        {
            FechaHoraDesde = fechaHoraDesde;
            FechaHoraHasta = fechaHoraHasta;
            Estado = estado;
        }
        public void setFechaHoraDesde(DateTime fechaHoraDesde)
        {
            FechaHoraDesde = fechaHoraDesde;
        }
        public void setFechaHoraHasta(DateTime? fechaHoraHasta)
        {
            FechaHoraHasta = fechaHoraHasta;
        }
        public void setEstado(Estado estado)
        {
            Estado = estado;
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
