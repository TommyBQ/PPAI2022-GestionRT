namespace PPAIGestionRecursosTecno2022.Models
{
    public class AsignacionResponsableTecnicoRT
    {
        private int _id;
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;
        private PersonalCientifico _personalCientifico;
        private List<RecursoTecnologico> _recursosTecnologicos;

        public int Id { get { return _id; } set { _id = value; } }
        public DateTime FechaDesde { get { return this._fechaDesde; } set { setFechaDesde(value); } }
        public DateTime? FechaHasta { get { return this._fechaHasta; } set { setFechaHasta(value); } }
        public PersonalCientifico PersonalCientifico { get { return this._personalCientifico; } set { this._personalCientifico = value; } }
        public List<RecursoTecnologico> RecursosTecnologicos { get { return this._recursosTecnologicos; } set { setRecursosTecnologicos(value); } }
        public AsignacionResponsableTecnicoRT(DateTime fechaDesde, DateTime? fechaHasta, PersonalCientifico personalCientifico)
        {
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            PersonalCientifico = personalCientifico;
            RecursosTecnologicos = new List<RecursoTecnologico>();
        }

        public void setFechaDesde(DateTime fechaDesde)
        {
            FechaHasta = fechaDesde;
        }
        public void setPersonalCientifico(PersonalCientifico personalCientifico)
        {
            PersonalCientifico = personalCientifico;
        }
        public void setFechaHasta(DateTime? fechaHasta)
        {
            FechaHasta = fechaHasta;
        }

        public void setRecursosTecnologicos(List<RecursoTecnologico> recursosTecnologicos)
        {
            RecursosTecnologicos = recursosTecnologicos;
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
