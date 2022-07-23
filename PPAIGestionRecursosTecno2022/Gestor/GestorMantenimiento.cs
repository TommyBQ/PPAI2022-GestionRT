using PPAIGestionRecursosTecno2022.Models;
using PPAIGestionRecursosTecno2022.Services;

namespace PPAIGestionRecursosTecno2022.Gestor
{
    public class GestorMantenimiento
    {
        private static GestorMantenimiento _gestorMantenimientoInstance;

        private DateTime _fechaFin;
        private string _motivo;
        private List<RecursoTecnologico> _recursos;
        private List<Turno> _turnos;
        private AsignacionResponsableTecnicoRT _asignacionResponsableTecnicoRT;
        private PersonalCientifico _personalCientifico;
        private Sesion _sesion;
        private List<AsignacionResponsableTecnicoRT> _listaAsignacionResponsableTecnicoRT;

        private List<PersonalCientifico> _listaPersonalesCientificos;

        public DateTime FechaFin { get { return _fechaFin; } }
        public string Motivo { get { return _motivo; } }
        public List<RecursoTecnologico> Recursos { get { return _recursos; } }
        public List<Turno> Turnos { get { return _turnos; } }
        public Sesion Sesion { get { return _sesion; } }
        public AsignacionResponsableTecnicoRT AsignacionCientifico { get { return _asignacionResponsableTecnicoRT; } }

        public void setSesion(Sesion sesionActiva)
        {
            _sesion = sesionActiva;
        }

        public List<PersonalCientifico> PersonalesCientificos { get { return _listaPersonalesCientificos; } }

        public static GestorMantenimiento GetInstanceGestor
        {
            get
            {
                if (_gestorMantenimientoInstance == null) _gestorMantenimientoInstance = new GestorMantenimiento();
                return _gestorMantenimientoInstance;
            }
        }

        public void cargarDatos()
        {
            _listaPersonalesCientificos = PersonalCientificoService.GetInstance.GetAll();
            _listaAsignacionResponsableTecnicoRT = AsignacionResponsableTecnicoRTService.GetInstance.GetAll();
        }

        public List<RecursoTecnologico> buscarRecursosDelResponsable()
        {
            cargarDatos(); //Se cargan todos los datos en el gestor

            Usuario usuarioLogueado = Sesion.conocerUsuario();

            foreach (PersonalCientifico pers in _listaPersonalesCientificos)
            {
                if (pers.esTuUsuario(usuarioLogueado))
                {
                    _personalCientifico = pers; //Se encuentra el Personal Cientifico y se guarda en el gestor
                    break;
                }
            }

            foreach (AsignacionResponsableTecnicoRT asi in _listaAsignacionResponsableTecnicoRT)
            {
                if (asi.sosResponsableActual(_personalCientifico))
                {
                    _asignacionResponsableTecnicoRT = asi; //Se guarda la AsignacionActiva
                    break;
                }
            }

            if (_asignacionResponsableTecnicoRT != null)
            {
                _recursos = _asignacionResponsableTecnicoRT.getRecursosDisponibles();
            }

            string datos = buscarDatosRT(_recursos);
        }

        public string buscarDatosRT(List<RecursoTecnologico> rts)
        {
            string stringDatosRT = "";

            foreach (RecursoTecnologico rt in rts)
            {
                string datosDelRT = rt.getDatosDelRT();

                stringDatosRT += "//"+datosDelRT;
            }
        }
        public void buscarDatosCientifico()
        {

        }
        public void buscarEstadoCanceladoPorMantenimientoCorrectivo()
        {

        }
        public void buscarEstadoConIngresoAMantenimientoCorrectivo()
        {

        }
        public void verificarExistenciaDeTurnos()
        {

        }
        public void generarMantenimiento()
        {

        }
        public void notificarCientifico()
        {

        }
        public void generarCorreo()
        {

        }
        public void actualizarEstados()
        {

        }
        public void cancelarPlazoDeMantenimiento()
        {

        }
        public void finCU()
        {

        }

    }
}
