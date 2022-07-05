namespace PPAIGestionRecursosTecno2022.Models
{
    public class Modelo
    {
        private string nombre;
        //private List<Marca>? _marcas;

        public string Nombre { get { return nombre; } set { setNombre(value); } }
        //public List<Marca>? Marcas { get { return _marcas; } set { setMarcas(value); } }

        public Modelo(string nombre)
        {
            Nombre = nombre;
            //Marcas = marca;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

        //public void setMarcas(List<Marca> marcas)
        //{
        //    Marcas = marcas;
        //}

        public string getNombre()
        {
            return Nombre;
        }

        //public List<Marca> getMarcas()
        //{
        //    return Marcas;
        //}

        //public void AgregarMarca(Marca marca)
        //{
        //    Marcas.Add(marca);
        //}
    }
}
