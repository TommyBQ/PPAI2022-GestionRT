namespace PPAIGestionRecursosTecno2022.Models
{
    public class AsignacionCientificoCI
    {
        private int _id;
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;
        private PersonalCientifico _personalCientifico;
        private Turno _turno;

        public int Id { get { return _id; } set { _id = value; } }
        public DateTime FechaDesde { get { return this._fechaDesde; } set { setFechaDesde(value); } }
        public DateTime? FechaHasta { get { return this._fechaHasta; } set { setFechaHasta(value); } }
        public PersonalCientifico PersonalCientifico { get { return this._personalCientifico; } set { setPersonalCientifico(value); } }
        public Turno Turno { get { return this._turno; } set { setTurno(value); } }

        public AsignacionCientificoCI(DateTime fechaDesde, DateTime? fechaHasta, PersonalCientifico personalCientifico)
        {
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            PersonalCientifico = personalCientifico;
        }

        private void setFechaDesde(DateTime fechaDesde)
        {
            FechaDesde = fechaDesde;
        }

        private void setFechaHasta(DateTime? fechaHasta)
        {
            FechaHasta = fechaHasta;
        } 

        public void setPersonalCientifico(PersonalCientifico cientifico)
        {
            PersonalCientifico = cientifico;
        }
        public void setTurno(Turno turno)
        {
            Turno = turno;
        }
        public int getId()
        {
            return Id;
        }
        public PersonalCientifico getPersonalCientifico()
        {
            return PersonalCientifico;
        }
        public void tenesEstosTurnos()
        {

        }
    }
}
