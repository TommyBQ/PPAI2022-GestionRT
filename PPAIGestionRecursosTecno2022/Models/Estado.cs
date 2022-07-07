namespace PPAIGestionRecursosTecno2022.Models
{
    public class Estado
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private string _ambito;
        private bool _esReservable;
        private bool _esCancelable;

        public int Id { get { return _id; } }
        public string Nombre { get { return _nombre; } }
        public string Descripcion { get { return _descripcion; } }
        public string Ambito { get { return _ambito; } }

        public Estado(int id, string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _ambito = ambito;
            _esReservable = esReservable;
            _esCancelable = esCancelable;
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
