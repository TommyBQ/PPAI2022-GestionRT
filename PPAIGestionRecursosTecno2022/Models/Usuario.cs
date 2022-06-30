namespace PPAIGestionRecursosTecno2022.Models
{
    public class Usuario
    {
        private string _clave;
        private string _nombreUsuario;
        private int _id_usuario;
        private bool _habilitado;

        public string Clave { get { return _clave; } set { setClave(value); } }
        public string NombreUsuario { get { return _nombreUsuario; } set { setUsuario(value); } }
        public int Id_Usuario { get { return _id_usuario; } set { setIdUsuario(value); } }
        public bool Habilitado { get { return _habilitado; } set { setHabilitado(value); } }

        public Usuario(string clave, string usuario, int idUsuario, bool habilitado)
        {
            Clave = clave;
            NombreUsuario = usuario;
            Id_Usuario = idUsuario;
            Habilitado = habilitado;
        }

        public Usuario()
        {

        }

        public string getUsuario()
        {
            return this._nombreUsuario;
        }

        public string getClave()
        {
            return this._clave;
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
