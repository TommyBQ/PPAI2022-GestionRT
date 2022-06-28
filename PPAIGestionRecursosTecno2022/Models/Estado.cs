namespace PPAIGestionRecursosTecno2022.Models
{
    public class Estado
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }
        public Estado(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public void sosDisponible()
        {

        }
        public void sosConfirmado()
        {

        }
        public void sosPendiente()
        {

        }
        public void esConIngresoAMantenimientoCorrectivo()
        {

        }
        public void esCanceladoPorMantenimientoCorrectivo()
        {

        }
    }
}
