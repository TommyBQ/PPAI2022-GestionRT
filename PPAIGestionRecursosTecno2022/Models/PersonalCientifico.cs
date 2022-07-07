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
        private Usuario _usuario;

        public string Legajo { get { return _legajo; }  }
        public string Nombre { get { return _nombre; }  }
        public string Apellido { get { return _apellido; } }
        public string NumeroDocumento { get { return _numeroDocumento; } }
        public string CorreoInstitucional { get { return _correoInstitucional; } }
        public string CorreoPersonal { get { return _correoPersonal; }  }
        public string Telefono { get { return _telefono; } }
        public Usuario Usuario { get { return _usuario; }  }

        public PersonalCientifico()
        {

        }

        public PersonalCientifico(string legajo, string nombre, string apellido, string numeroDocumento, string correoInstitucional, string correoPersonal, string telefono, Usuario usuario)
        {
            _legajo = legajo;
            _nombre = nombre;
            _apellido = apellido;
            _numeroDocumento = numeroDocumento;
            _correoInstitucional = correoInstitucional;
            _correoPersonal = correoPersonal;
            _telefono = telefono;
            _usuario = usuario;
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
        public Usuario getUsuario()
        {
            return Usuario;
        }

        public bool esTuUsuario(Usuario user)
        {
            return getUsuario() == user;
        }
    }
}
