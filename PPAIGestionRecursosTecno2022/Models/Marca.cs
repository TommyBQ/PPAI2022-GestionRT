namespace PPAIGestionRecursosTecno2022.Models
{
    public class Marca
    {
        private int _id;
        private string _nombre;
        private List<Modelo> _modeloList;

        public int Id { get { return _id; } }
        public string Nombre { get { return _nombre; } }
        public List<Modelo> ModeloList { get { return _modeloList; } }

        public Marca(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }
        public string getNombre() // == getMarca()
        {
            return Nombre;
        }

        public void agregarModelo(Modelo model)
        {
            if (_modeloList == null)
            {
                _modeloList = new List<Modelo>();
            }
            _modeloList.Add(model);
        }
    }
}
