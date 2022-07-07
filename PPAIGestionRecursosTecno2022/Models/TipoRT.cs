namespace PPAIGestionRecursosTecno2022.Models
{
    public class TipoRT
    {
        private int _id;
        private string _nombre;
        private string _descripcion;

        public int Id { get { return _id; } }
        public string Nombre { get { return _nombre; } }
        public string Descripcion { get { return _descripcion; }  }

        public TipoRT(int id, string nombre, string descripcion)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
        }

        public string getNombre()
        {
            return Nombre;
        }
        public string getDescripcion()
        {
            return Descripcion;
        }
    }
}
