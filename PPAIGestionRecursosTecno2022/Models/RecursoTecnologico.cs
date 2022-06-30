namespace PPAIGestionRecursosTecno2022.Models
{
    public class RecursoTecnologico
    {
        private int _numeroRT;
        private DateTime _fechaAlta;
        private Modelo _modelo;
        private TipoRT _tipo;
        private List<Turno>? _turno;
        private List<CambioEstadoRT> _cambioEstado;

        public int NumeroRT { get { return _numeroRT; } set { _numeroRT = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { _fechaAlta = value;} }
        public Modelo Modelo { get { return _modelo; } set { _modelo = value; } }
        public TipoRT Tipo { get { return _tipo; } set { _tipo = value; } }
        public List<Turno>? Turno { get { return _turno; } set { _turno = value; } }
        public List<CambioEstadoRT> CambioEstado { get { return _cambioEstado; } set { _cambioEstado = value; } }

        public void AgregarCambioEstadoRT(CambioEstadoRT cambioEstadoRT)
        {
            _cambioEstado.Add(cambioEstadoRT);
        }        
        
        public void AgregarTurno(Turno turno)
        {
            _turno.Add(turno);
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
