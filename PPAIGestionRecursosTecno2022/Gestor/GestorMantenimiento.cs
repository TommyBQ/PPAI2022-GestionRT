using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Gestor
{
    public class GestorMantenimiento
    {
        private DateTime fechaFin { get; set; }
        private string motivo { get; set; }
        private List<RecursoTecnologico> recursos { get; }
        private List<Turno> turnos { get; }
        private AsignacionCientificoCI cientifico { get; }
        private Sesion sesion { get; }
        private AsignacionCientificoCI asignacionCientifico { get; }


        public GestorMantenimiento(DateTime fechaFin, string motivo, List<RecursoTecnologico> recursos, List<Turno> turnos, AsignacionCientificoCI cientifico)
        {
            this.fechaFin = fechaFin;
            this.motivo = motivo;
            this.recursos = recursos;
            this.turnos = turnos;
            this.cientifico = cientifico;
        }

        public void buscarRecursosDelResponsable()
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
