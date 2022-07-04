namespace PPAIGestionRecursosTecno2022.Models
{
    public class AsignacionCientificoCI
    {
        private int _id;
        private DateTime _fechaDesde;
        private DateTime? _fechaHasta;
        private PersonalCientifico _personalCientifico;
        private Turno _turno;

        public int Id { get { return _id; } }
        public DateTime FechaDesde { get { return _fechaDesde; } }
        public DateTime? FechaHasta { get { return _fechaHasta; }}
        public PersonalCientifico PersonalCientifico { get { return _personalCientifico; } }
        public Turno Turno { get { return _turno; } }

        public AsignacionCientificoCI(int id, DateTime fechaDesde, DateTime? fechaHasta, PersonalCientifico personalCientifico, Turno turno)
        {
            _id = id;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _personalCientifico = personalCientifico;
            _turno = turno;
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
