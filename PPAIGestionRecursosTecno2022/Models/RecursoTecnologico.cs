namespace PPAIGestionRecursosTecno2022.Models
{
    public class RecursoTecnologico
    {
        private int _numeroRT;
        private string _nombre;
        private DateTime _fechaAlta;
        private Modelo _modelo;
        private TipoRT _tipo;
        private List<Turno>? _turno;
        private List<CambioEstadoRT> _cambioEstado;
        private string _imagen;

        public string Nombre { get { return _nombre; } set { setNombre(value); } }
        public int NumeroRT { get { return _numeroRT; } set { setNumeroRT(value); } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { setFechaAlta(value); } }
        public Modelo Modelo { get { return _modelo; } set { setModelo(value); } }
        public TipoRT Tipo { get { return _tipo; } set { setTipo(value); } }
        public List<Turno>? Turno { get { return _turno; } set { setTurnos(value); } }
        public List<CambioEstadoRT> CambioEstado { get { return _cambioEstado; } set { setCambioEstadoRT(value); } }
        public string Imagen { get { return _imagen; } set { setImagen(value); } }

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, Modelo modelo, TipoRT tipo, List<Turno>? turno, List<CambioEstadoRT> cambioEstado)
        {
            NumeroRT = numeroRT;
            FechaAlta = fechaAlta;
            Modelo = modelo;
            Tipo = tipo;
            Turno = turno;
            CambioEstado = cambioEstado;
        }

        public int getNumeroRT()
        {
            return NumeroRT;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public DateTime getFechaAlta()
        {
            return FechaAlta;
        }
        public TipoRT getTipo()
        {
            return Tipo;
        }
        public List<Marca> getMarcas()
        {
            return Modelo.getMarcas();
        }
        public Modelo getModelo()
        {
            return Modelo;
        }
        public List<Turno>? getTurnos()
        {
            return Turno;
        }
        public List<CambioEstadoRT> getCambioEstadoRT()
        {
            return CambioEstado;
        }
        public string getImagen()
        {
            return Imagen;
        }
        public void setNumeroRT(int numRT)
        {
            NumeroRT = numRT;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void setFechaAlta(DateTime fechaAlta)
        {
            FechaAlta = fechaAlta;
        }
        public void setTipo(TipoRT tipo)
        {
            Tipo = tipo;
        }
        public void setTurnos(List<Turno>? turnos)
        {
            Turno = turnos;
        }
        public void setModelo(Modelo modelos)
        {
            Modelo = modelos;
        }
        public void setCambioEstadoRT(List<CambioEstadoRT> cambioEstados)
        {
            CambioEstado = cambioEstados;
        }
        public void setImagen(string imagen)
        {
            Imagen = imagen;
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
