using PPAIGestionRecursosTecno2022.DAO;
using PPAIGestionRecursosTecno2022.Exceptions;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Gestor
{
    public class GestorMantenimiento
    {
        private DateTime _fechaFin;
        private string _motivo;
        private List<RecursoTecnologico> _recursos;
        private List<Turno> _turnos;
        private AsignacionCientificoCI _cientifico;
        private PersonalCientifico _personalCientifico;
        private Sesion _sesion;
        private AsignacionCientificoCI _asignacionCientifico;

        private static GestorMantenimiento _gestorMantenimientoInstance;

        public DateTime FechaFin { get { return _fechaFin; } set { setFechaFin(value); } }
        public string Motivo { get { return _motivo; } set { setMotivo(value); } }
        public List<RecursoTecnologico> Recursos { get { return _recursos; } set { setRecursos(value); } }
        public List<Turno> Turnos { get { return _turnos; } set { setTurnos(value); } }
        public Sesion Sesion { get { return _sesion; } set { setSesion(value); } }
        public AsignacionCientificoCI AsignacionCientifico { get { return _cientifico; } set { setAsignacionCientifico(value); } }

        public static GestorMantenimiento GetInstanceGestor
        {
            get
            {
                if (_gestorMantenimientoInstance == null) throw new Exception("No se inició gestor.");
                return _gestorMantenimientoInstance = new GestorMantenimiento();
            }
        }

        private GestorMantenimiento()
        {
        }
        public void setFechaFin(DateTime fechaFin)
        {
            _fechaFin = fechaFin;
        }

        public void setMotivo(string motivo)
        {
            _motivo = motivo;
        }

        public void setRecursos(List<RecursoTecnologico> recursosTecnologicos)
        {
            _recursos = recursosTecnologicos;
        }

        public void setTurnos(List<Turno> turnos)
        {
            _turnos = turnos;
        }

        public static void setSesion(Sesion sesion)
        {
            if (_gestorMantenimientoInstance == null)
            {
                _gestorMantenimientoInstance = new GestorMantenimiento();
                _gestorMantenimientoInstance.Sesion = sesion;
            }
        }

        public void setAsignacionCientifico(AsignacionCientificoCI asignacionCientifico)
        {
            _asignacionCientifico = asignacionCientifico;
        }

        public static void buscarRecursosDelResponsable()
        {
            PersonalCientificoDAO pcDAO = new PersonalCientificoDAO();
            AsignacionResponsableTecnicoRTDAO asignacionResponsableTecnicoRTDAO = new AsignacionResponsableTecnicoRTDAO();

            PersonalCientifico personalCientifico;

            try
            {
                SessionManager usuarioSesionActiva = SessionManager.GetInstance;
                List<PersonalCientifico> listAllPersonalCientifico = pcDAO.GetAllPersonalCientifico();
                List<AsignacionResponsableTecnicoRT> listAllAsignacionResponsableTecnicoRT = asignacionResponsableTecnicoRTDAO.GetAllAsignacionResponsableTecnicoRT();

                foreach (PersonalCientifico persCien in listAllPersonalCientifico)
                {
                    if (persCien.esTuUsuario(persCien.IdUsuario))
                    {
                        GestorMantenimiento.setPersonalCientifico(persCien);
                    }
                }

                foreach (AsignacionResponsableTecnicoRT asignacion in listAllAsignacionResponsableTecnicoRT)
                {
                    if (asignacion.sosResponsableActual(GestorMantenimiento.getPersonalCientifico()))
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo buscar recurso del responsable." + ex.Message);
            }
        }

        private static PersonalCientifico getPersonalCientifico()
        {
            return _gestorMantenimientoInstance._personalCientifico;
        }

        private static void setPersonalCientifico(PersonalCientifico persCien)
        {
            if (_gestorMantenimientoInstance != null )_gestorMantenimientoInstance._personalCientifico = persCien;
        }

        public void buscarDatosRT()
        {

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

        public DateTime getFechaFin(DateTime fechaFin)
        {
            return FechaFin;
        }

        public string getMotivo(string motivo)
        {
            return Motivo;
        }

        public List<RecursoTecnologico> getRecursos(List<RecursoTecnologico> recursosTecnologicos)
        {
            return Recursos;
        }

        public List<Turno> getTurnos(List<Turno> turnos)
        {
            return Turnos;
        }
        public Sesion getSesion()
        {
            return Sesion;
        }
        public AsignacionCientificoCI getAsignacionCientifico(AsignacionCientificoCI asignacionCientifico)
        {
            return AsignacionCientifico;
        }

    }
}
