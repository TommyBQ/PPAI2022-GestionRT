namespace PPAIGestionRecursosTecno2022.Models
{
    public class Modelo
    {
        private int _id;
        private string _nombre;

        public int Id { get { return _id; } }
        public string Nombre { get { return _nombre; } }

        public Modelo(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }

        public string getNombre()
        {
            return Nombre;
        }
    }
}
