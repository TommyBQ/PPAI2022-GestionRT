namespace PPAIGestionRecursosTecno2022.Models
{
    public class Usuario
    {
        private int _id_usuario;
        private string _clave;
        private string _nombreUsuario;
        private bool _habilitado;

        public int Id_Usuario { get { return _id_usuario; }}
        public string Clave { get { return _clave; } }
        public string NombreUsuario { get { return _nombreUsuario; } }
        public bool Habilitado { get { return _habilitado; } }

        public Usuario(int id_usuario, string clave, string nombreUsuario, bool habilitado)
        {
            _id_usuario = id_usuario;
            _clave = clave;
            _nombreUsuario = nombreUsuario;
            _habilitado = habilitado;
        }

        public string getUsuario()
        {
            return NombreUsuario;
        }

        public string getClave()
        {
            return Clave;
        }

        public int getIdUsuario(int idUser)
        {
            return Id_Usuario;
        }
        public bool getHabilitado(bool habilitado)
        {
            return Habilitado;
        }

        public void setUsuario(string nombreUser)
        {
            _nombreUsuario = nombreUser;
        }

        public void setClave(string clave)
        {
            _clave = clave;
        }

        public void setIdUsuario(int idUser)
        {
            _id_usuario = idUser;
        }
        public void setHabilitado(bool habilitado)
        {
            _habilitado = habilitado;
        }
    }
}
