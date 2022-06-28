namespace PPAIGestionRecursosTecno2022.Models
{
    public class AsignacionCientificoCI
    {
        private DateTime fechaDesde { get; set; }
        private DateTime? fechaHasta { get; set; }
        private PersonalCientifico _personalCientifico { get; set; }

        public AsignacionCientificoCI(DateTime fechaDesde, DateTime? fechaHasta, PersonalCientifico personalCientifico)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this._personalCientifico = personalCientifico;
        }

        public void setPersonalCientifico(PersonalCientifico cientifico)
        {
            this._personalCientifico = cientifico;
        }

        public void tenesEstosTurnos()
        {

        }

        public void getPersonalCientifico()
        {

        }
    }
}
