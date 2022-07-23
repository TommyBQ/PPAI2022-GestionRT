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

        public string getMarca(List<Marca> marcas)
        {
            string nombreMarca = "";

            foreach (Marca marca in marcas)
            {
                foreach (Modelo modelo in marca.ModeloList)
                {
                    if (modelo.Nombre == _nombre)
                    {
                        nombreMarca = marca.Nombre;
                        break;
                    }
                }
            }

            return nombreMarca;
        }
    }
}
