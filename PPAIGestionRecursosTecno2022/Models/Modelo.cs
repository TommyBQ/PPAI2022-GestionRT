namespace PPAIGestionRecursosTecno2022.Models
{
    public class Modelo
    {
        private string nombre { get; set; }
        private List<Modelo> _modelo { get; set; }

        public Modelo(string nombre, Modelo modelo)
        {
            this.nombre = nombre;
            _modelo = new List<Modelo>();
        }

        public IReadOnlyCollection<Modelo> ModeloLectura
        {
            get { return _modelo.AsReadOnly(); }
        }

        public void AgregarModelo(Modelo modelo)
        {
            this._modelo.Add(modelo);
        }

        public void getModelo()
        {

        }
    }
}
