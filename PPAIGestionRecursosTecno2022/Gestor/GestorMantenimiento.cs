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

        public DateTime FechaFin { get { return _fechaFin; } set { _fechaFin = value; } }
        public string Motivo { get { return _motivo; } set { _motivo = value; } }
        public List<RecursoTecnologico> Recursos { get { return _recursos; } set { _recursos = value; } }
        public List<Turno> Turnos { get { return _turnos; } set { _turnos = value; } }
        public Sesion Sesion { get { return _sesion; } set { setSesion(value); } }
        public AsignacionCientificoCI AsignacionCientifico { get { return _cientifico; } set { _cientifico = value; } }

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
        public void setSesion(Sesion sesion)
        {
            _sesion = sesion;
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


        public Sesion getSesion()
        {
            return Sesion;
        }
    }
}
