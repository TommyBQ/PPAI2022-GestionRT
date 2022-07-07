using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022
{
    // Esto es puramente un patrón SINGLETON. Es decir que, solo puede tener una instancia para TODA la aplicacion.
    // Que se comporte asi permite que en cualquier clase podamos conocer qué usuario inició sesión y podremos loguear y desloguear.
    public class SessionManager
    {
        private static SessionManager _session;

        Usuario usuario;

        public static SessionManager GetInstance
        {
            get
            {
                if (_session == null) throw new Exception("Sesion no iniciada.");
                return _session;
            }
        }

        public static void Login(Usuario usuario)
        {
            if (_session == null)
            {
                _session = new SessionManager();
                _session.usuario = usuario;
            }
            else
            {
                throw new Exception("Sesión ya iniciada.");
            }
        }

        public static void Logout()
        {
            if (_session != null)
            {
                _session = null;
            }
            else
            {
                throw new Exception("Sesión no iniciada.");
            }
        }

        public static Usuario conocerUsuario()
        {
            if (_session != null)
            {
                return _session.usuario;
            }
            else
            {
                throw new Exception("Sesion no iniciada.");
            }
        }

        private SessionManager()
        {

        }
    }
}
