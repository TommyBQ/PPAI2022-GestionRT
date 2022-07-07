namespace PPAIGestionRecursosTecno2022.Models
{
    public class Mantenimiento
    {
        private int _id;
        private DateTime _fechaFin;
        private DateTime _fechaInicio;
        private DateTime _fechaInicioPrevista;
        private string _motivoMantenimiento;
        private RecursoTecnologico _recursoTecnologico;

        public int Id { get { return _id; } }
        public DateTime FechaFin { get { return _fechaFin; }}
        public DateTime FechaInicio { get { return _fechaInicio; } }
        public DateTime FechaInicioPrevista { get { return _fechaInicioPrevista; } }
        public string MotivoMantenimiento { get { return _motivoMantenimiento; } }

        public Mantenimiento(int id, DateTime fechaFin, DateTime fechaInicio, DateTime fechaInicioPrevista, string motivoMantenimiento, RecursoTecnologico recursoTecnologico)
        {
            _id = id;
            _fechaFin = fechaFin;
            _fechaInicio = fechaInicio;
            _fechaInicioPrevista = fechaInicioPrevista;
            _motivoMantenimiento = motivoMantenimiento;
            _recursoTecnologico = recursoTecnologico;
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
