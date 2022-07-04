namespace PPAIGestionRecursosTecno2022.Models
{
    public class PersonalCientifico
    {
        private string _legajo;
        private string _nombre;
        private string _apellido;
        private string _numeroDocumento;
        private string _correoInstitucional;
        private string _correoPersonal;
        private string _telefono;
        private int _idUsuario;

        public string Legajo { get { return _legajo; } set { _legajo = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string NumeroDocumento { get { return _numeroDocumento; } set { _numeroDocumento = value; } }
        public string CorreoInstitucional { get { return _correoInstitucional; } set { _correoInstitucional = value; } }
        public string CorreoPersonal { get { return _correoPersonal; } set { _correoPersonal = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }
        public int IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }

        public PersonalCientifico()
        {

        }

        public PersonalCientifico(string legajo, string nombre, string apellido, string numeroDocumento, string correoInstitucional, string correoPersonal, string telefono, int idUsuario)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            NumeroDocumento = numeroDocumento;
            CorreoInstitucional = correoInstitucional;
            CorreoPersonal = correoPersonal;
            Telefono = telefono;
            IdUsuario = idUsuario;
        }

        public void setLegajo(string legajo)
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
        public void setCorreoInstitucional(string correo)
        {
            CorreoInstitucional = correo;
        }
        public void setCorreoPersonal(string correo)
        {
            CorreoPersonal = correo;
        }
        public void setIdUsuario(int idUser)
        {
            IdUsuario = idUser;
        }
        public string getLegajo()
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
        public string getCorreoInstitucional()
        {
            return CorreoInstitucional;
        }
        public string getCorreoPersonal()
        {
            return CorreoPersonal;
        }
        public int getIdUsuario()
        {
            return IdUsuario;
        }

        public bool esTuUsuario(int idUsuario)
        {
            return SessionManager.GetUsuarioActivo().Id_Usuario == idUsuario;
        }
    }
}
