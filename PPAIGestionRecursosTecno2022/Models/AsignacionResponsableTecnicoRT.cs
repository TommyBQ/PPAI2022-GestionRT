namespace PPAIGestionRecursosTecno2022.Models
{
    public class AsignacionResponsableTecnicoRT
    {
        private int _id;
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;
        private PersonalCientifico _personalCientifico;
        private List<RecursoTecnologico> _recursosTecnologicos;

        public int Id { get { return _id; } }
        public DateTime FechaDesde { get { return this._fechaDesde; } }
        public DateTime? FechaHasta { get { return this._fechaHasta; } }
        public PersonalCientifico PersonalCientifico { get { return this._personalCientifico; } }
        public List<RecursoTecnologico> RecursosTecnologicos { get { return this._recursosTecnologicos; }}

        public AsignacionResponsableTecnicoRT(int id, DateTime fechaDesde, DateTime? fechaHasta, PersonalCientifico personalCientifico, List<RecursoTecnologico> recursosTecnologicos)
        {
            _id = id;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _personalCientifico = personalCientifico;
            _recursosTecnologicos = recursosTecnologicos;
        }

        public int getId()
        {
            return Id;
        }
        public DateTime getFechaDesde()
        {
            return FechaDesde;
        }
        public PersonalCientifico getPersonalCientifico()
        {
            return PersonalCientifico;
        }
        public DateTime? getFechaHasta()
        {
            return FechaHasta;
        }

        public List<RecursoTecnologico> getRecursosTecnologicos()
        {
            return RecursosTecnologicos;
        }

        public void AgregarRecursoTecnologico(RecursoTecnologico recurso)
        {
            RecursosTecnologicos.Add(recurso);
        }

        public bool sosResponsableActual(PersonalCientifico personalCientifico)
        {
            return PersonalCientifico == personalCientifico;
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
