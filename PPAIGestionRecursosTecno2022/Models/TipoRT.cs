namespace PPAIGestionRecursosTecno2022.Models
{
    public class TipoRT
    {
        private string _nombre;
        private string _descripcion;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }

        public TipoRT(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public string getNombre()
        {
            return Nombre;
        }
        public string getDescripcion()
        {
            return Descripcion;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void setDescripcion(string desc)
        {
            Descripcion = desc;
        }
    }
}
