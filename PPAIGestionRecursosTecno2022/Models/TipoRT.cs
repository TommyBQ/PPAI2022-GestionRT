namespace PPAIGestionRecursosTecno2022.Models
{
    public class TipoRT
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }

        public TipoRT(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
