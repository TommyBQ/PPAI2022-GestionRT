namespace PPAIGestionRecursosTecno2022.Models
{
    public class Marca
    {
        private int _id;
        private string _nombre;

        private int Id { get { return _id; } set { _id = value; } } 
        public string Nombre { get { return _nombre; } set { setNombre(value); } }

        public Marca(string nombre)
        {
            Nombre = nombre;
        }
        public int getId()
        {
            return Id;
        }
        public void setNombre(string nom)
        {
            Nombre = nom;
        }

        public string getNombre() // == getMarca()
        {
            return Nombre;
        }
    }
}
