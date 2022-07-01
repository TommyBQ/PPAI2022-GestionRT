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
        private Sesion _sesion;
        private AsignacionCientificoCI _asignacionCientifico;

        public DateTime FechaFin { get { return _fechaFin; } set { setFechaFin(value); } }
        public string Motivo { get { return _motivo; } set { setMotivo(value); } }
        public List<RecursoTecnologico> Recursos { get { return _recursos; } set { setRecursos(value); } }
        public List<Turno> Turnos { get { return _turnos; } set { setTurnos(value); } }
        public Sesion Sesion { get { return _sesion; } set { setSesion(value); } }
        public AsignacionCientificoCI AsignacionCientifico { get { return _cientifico; } set { setAsignacionCientifico(value); } }

        public GestorMantenimiento(DateTime fechaFin, string motivo, List<RecursoTecnologico> recursos, List<Turno> turnos, AsignacionCientificoCI asignacionCientifico, Sesion sesion)
        {
            FechaFin = fechaFin;
            Motivo = motivo;
            Recursos = recursos;
            Turnos = turnos;
            AsignacionCientifico = asignacionCientifico;
            Sesion = sesion;
        }

        public GestorMantenimiento()
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

        public void setSesion(Sesion sesion)
        {
            _sesion = sesion;
        }

        public void setAsignacionCientifico(AsignacionCientificoCI asignacionCientifico)
        {
            _asignacionCientifico = asignacionCientifico;
        }

        public void buscarRecursosDelResponsable()
        {
            Usuario usuarioSesionActiva = Sesion.conocerUsuario();

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
