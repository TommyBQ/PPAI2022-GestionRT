namespace PPAIGestionRecursosTecno2022.Models
{
    public class Estado
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private string _ambito;

        private int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { setNombre(value); } }
        public string Descripcion { get { return _descripcion; } set { setDescripcion(value); } }
        public string Ambito { get { return _ambito; } set { setAmbito(value); } }

        public Estado(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

        public void setDescripcion(string descrip)
        {
            Descripcion = descrip;
        }
        public void setAmbito(string ambito)
        {
            Ambito = ambito;
        }

        public int getId()
        {
            return Id;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getDescripcion()
        {
            return Descripcion;
        }

        public bool sosDisponible()
        {
            return Nombre == "Disponible";
        }
        public bool sosConfirmado()
        {
            return Nombre == "Confirmado";
        }
        public bool sosPendiente()
        {
            return Nombre == "Pendiente";
        }
        public bool esConIngresoAMantenimientoCorrectivo()
        {
            return Nombre == "Ingreso a Mantenimiento Correctivo";
        }
        public bool esCanceladoPorMantenimientoCorrectivo()
        {
            return Nombre == "Cancelado por Mantenimiento Correctivo";
        }
    }
}
