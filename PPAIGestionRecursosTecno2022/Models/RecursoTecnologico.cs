namespace PPAIGestionRecursosTecno2022.Models
{
    public class RecursoTecnologico
    {
        private int _numeroRT;
        private string _nombre;
        private DateTime? _fechaAlta;
        private Modelo _modelo;
        private TipoRT _tipo;
        private List<Turno>? _turno;
        private List<CambioEstadoRT> _cambioEstado;
        private Mantenimiento _mantenimiento;
        private string _imagen;
        //Se hace el get publico pero el set privado, entonces un método publico tiene que setear estas propiedades
        public string Nombre { get { return _nombre; } }
        public int NumeroRT { get { return _numeroRT; } }
        public DateTime? FechaAlta { get { return _fechaAlta; } }
        public Modelo Modelo { get { return _modelo; } }
        public TipoRT Tipo { get { return _tipo; } }
        public List<Turno>? Turno { get { return _turno; } }
        public List<CambioEstadoRT> CambioEstado { get { return _cambioEstado; } }
        public Mantenimiento Mantenimiento { get { return _mantenimiento; } }
        public string Imagen { get { return _imagen; } }

        public RecursoTecnologico(int numeroRT, string nombre, DateTime? fechaAlta, Modelo modelo, TipoRT tipo, List<Turno>? turno, List<CambioEstadoRT> cambioEstado,Mantenimiento mantenimiento, string imagen)
        {
            _numeroRT = numeroRT;
            _nombre = nombre;
            _fechaAlta = fechaAlta;
            _modelo = modelo;
            _tipo = tipo;
            _turno = turno;
            _cambioEstado = cambioEstado;
            _mantenimiento = mantenimiento;
            _imagen = imagen;
        }
        public void AgregarCambioEstadoRT(CambioEstadoRT cambioEstadoRT)
        {
            _cambioEstado.Add(cambioEstadoRT);
        }

        public void AgregarTurno(Turno turno)
        {
            if (Turno != null)
            {
                Turno.Add(turno);
            }
        }

        public void estaDisponible()
        {

        }
        public void tenesTurnosCOnfirmadosOPendientes()
        {

        }
        public void obtenerDatoTurnos() //getTurnos?
        {

        }
    }
}
