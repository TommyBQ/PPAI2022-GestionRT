using PPAIGestionRecursosTecno2022.Models;
using PPAIGestionRecursosTecno2022.Services;

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

        public DateTime FechaFin { get { return _fechaFin; } }
        public string Motivo { get { return _motivo; } }
        public List<RecursoTecnologico> Recursos { get { return _recursos; } }
        public List<Turno> Turnos { get { return _turnos; } }
        public Sesion Sesion { get { return _sesion; } }
        public AsignacionCientificoCI AsignacionCientifico { get { return _cientifico; } }

        public static GestorMantenimiento GetInstanceGestor
        {
            get
            {
                if (_gestorMantenimientoInstance == null) _gestorMantenimientoInstance = new GestorMantenimiento();
                return _gestorMantenimientoInstance;
            }
        }


        public static void setSesion(Sesion sesion)
        {
            if (_gestorMantenimientoInstance == null)
            {
                _gestorMantenimientoInstance = new GestorMantenimiento();
                _gestorMantenimientoInstance._sesion = sesion;
            }
        }

        public static void buscarRecursosDelResponsable()
        {

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

    }
}
