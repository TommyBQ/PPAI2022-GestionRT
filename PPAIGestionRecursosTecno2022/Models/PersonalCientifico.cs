namespace PPAIGestionRecursosTecno2022.Models
{
    public class PersonalCientifico
    {
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private string _correo;
        private int _idUsuario;

        public int Legajo { get { return _legajo; } set { _legajo = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }
        public int IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }

        public PersonalCientifico(int legajo, string nombre, string apellido, string correo, int idUsuario)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            IdUsuario = idUsuario;
        }

        public void setLegajo(int legajo)
        {
            Legajo = legajo;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            Apellido = apellido;
        }
        public void setCorreo(string correo)
        {
            Correo = correo;
        }
        public void setIdUsuario(int idUser)
        {
            IdUsuario = idUser;
        }
        public int getLegajo()
        {
            return Legajo;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public string getApellido()
        {
            return Apellido;
        }
        public string getCorreo()
        {
            return Correo;
        }
        public int getIdUsuario()
        {
            return IdUsuario;
        }

        public bool esTuUsuario(int idUsuario)
        {
            return IdUsuario == idUsuario;
        }
    }
}
