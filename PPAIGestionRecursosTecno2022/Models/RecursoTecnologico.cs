namespace PPAIGestionRecursosTecno2022.Models
{
    public class RecursoTecnologico
    {
        private int numeroRT { get; set; }
        private DateTime fechaAlta { get; set; }
        private Modelo _modelo { get; set; }
        private TipoRT _tipo { get; set; }
        private List<Turno>? _turno { get; set; }
        private List<CambioEstadoRT> _cambioEstado { get; set; }

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, Modelo modelo, TipoRT tipo)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this._modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
            this._tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            this._turno = new List<Turno>();
            this._cambioEstado = new List<CambioEstadoRT>();
        }

        public void AgregarCambioEstadoRT(CambioEstadoRT cambioEstadoRT)
        {
            _cambioEstado.Add(cambioEstadoRT);
        }        
        
        public void AgregarTurno(Turno turno)
        {
            _turno.Add(turno);
        }

        public IReadOnlyCollection<CambioEstadoRT> CambioEstado
        {
            get { return _cambioEstado.AsReadOnly(); }
        }        
        
        public IReadOnlyCollection<Turno> Turno
        {
            get { return _turno.AsReadOnly(); }
        }

        public void estaDisponible()
        {

        }
        public void getNro()
        {

        }
        public void getTipo()
        {

        }
        public void getMarca()
        {

        }
        public void getModelo()
        {

        }
        public void tenesTurnosCOnfirmadosOPendientes()
        {

        }
        public void obtenerDatoTurnos()
        {

        }
        public void setEstado()
        {

        }
    }
}
