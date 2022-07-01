namespace PPAIGestionRecursosTecno2022.Models
{
    public class Mantenimiento
    {
        private DateTime _fechaFin;
        private DateTime _fechaInicio;
        private DateTime _fechaInicioPrevista;
        private string _motivoMantenimiento;

        public DateTime FechaFin { get { return _fechaFin; } set { _fechaFin = value; } }
        public DateTime FechaInicio { get { return _fechaInicio; } set { _fechaInicio = value; } }
        public DateTime FechaInicioPrevista { get { return _fechaInicioPrevista; } set { _fechaInicioPrevista = value; } }
        public string MotivoMantenimiento { get { return _motivoMantenimiento; } set { _motivoMantenimiento = value; } }

        public Mantenimiento(DateTime fechaFin, DateTime fechaInicio, DateTime fechaInicioPrevista, string motivoMantenimiento)
        {
            FechaFin = fechaFin;
            FechaInicio = fechaInicio;
            FechaInicioPrevista = fechaInicioPrevista;
            MotivoMantenimiento = motivoMantenimiento;
        }

        public void setFechaFin()
        {

        }
        public void setFechaInicio()
        {

        }
        public void setFechaInicioPrevista()
        {

        }
        public void setMotivoMantenimiento()
        {

        }
        public void getFechaFin()
        {

        }
        public void getFechaInicio()
        {

        }
        public void getFechaInicioPrevista()
        {

        }
        public void getMotivoMantenimiento()
        {

        }

        public void mostrarMantenimiento()
        {

        }
        public void iniciar()
        {

        }
        public void finalizar()
        {

        }
        public void esPreventivo()
        {

        }
        public void extender()
        {

        }
        public void calcularDuracionTotal()
        {

        }
    }
}
