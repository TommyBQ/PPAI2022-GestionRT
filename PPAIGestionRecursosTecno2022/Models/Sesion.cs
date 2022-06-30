namespace PPAIGestionRecursosTecno2022.Models
{
    public class Sesion
    {
        private string _descripcion;
        private Usuario _usuario;

        public string Descripcion { get { return _descripcion; } set { setDescripcion(value); } }
        public Usuario Usuario { get { return _usuario; } set { setUsuario(value); } }

        public Sesion()
        {
        }
        public Sesion(string descripcion, Usuario usuario)
        {
            Descripcion = descripcion;
            Usuario = usuario;
        }

        public void setSesion(string descripcion, Usuario usuario)
        {
            setDescripcion(descripcion);
            setUsuario(usuario);
        }

        public void setUsuario(Usuario user)
        {
            _usuario = user;
        }

        public void setDescripcion(string desc)
        {
            _descripcion = desc;
        }


        public Usuario conocerUsuario()
        {
            return Usuario;
        }
    }
}
