namespace PPAIGestionRecursosTecno2022.Models
{
    public class AsignacionResponsableTecnicoRT
    {
        private DateTime fechaDesde { get; set; }
        private DateTime? fechaHasta { get; set; }
        private List<RecursoTecnologico> _recursoTecnologico { get; set; }

        public AsignacionResponsableTecnicoRT(DateTime fechaDesde, DateTime? fechaHasta, List<RecursoTecnologico> recursoTecnologico)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            _recursoTecnologico = new List<RecursoTecnologico>();
        }

        public IReadOnlyCollection<RecursoTecnologico> RecursoTecnologico
        {
            get { return _recursoTecnologico.AsReadOnly(); }
        }

        public void AgregarRecursoTecnologico(RecursoTecnologico recurso)
        {
            _recursoTecnologico.Add(recurso);
        }

        public void sosResponsableActual()
        {

        }

        public void crear()
        {

        }

        public void mostrarCientificoDeCI()
        {

        }

        public void misTurnos()
        {

        }
    }
}
