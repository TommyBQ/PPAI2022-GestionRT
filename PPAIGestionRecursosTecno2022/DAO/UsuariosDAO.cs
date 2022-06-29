using Dapper;
using Microsoft.Data.SqlClient;
using PPAIGestionRecursosTecno2022.Models;
using System.Data;

namespace PPAIGestionRecursosTecno2022.DAO
{
    public class UsuariosDAO
    {
        private string cadena { get { return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PPAI_2022;Integrated Security=True"; } }

        public List<Usuario> GetAllUsuarios()
        {
            List<Usuario> allUsers = new List<Usuario>();
            using (IDbConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();

                var usuarios = conexion.Query("_paBuscarUsuarios", commandType: CommandType.StoredProcedure).ToList();

                if (usuarios != null)
                {
                    foreach (var user in usuarios)
                    {
                        int idUser = (int)user.id_usuario;
                        string claveUser = (string)user.clave;
                        string nombreUser = (string)user.usuario;
                        bool habilitadoUser = (bool)user.habilitado;

                        Usuario usuario = new Usuario(claveUser, nombreUser, idUser, habilitadoUser);
                        allUsers.Add(usuario);
                    }
                }
                return allUsers;
            }
        }

        public bool ValidarUsuario(string usuario, string clave)
        {
            List<Usuario> allUsers = GetAllUsuarios();
            bool validado = false;

            foreach (var us in allUsers)
            {
                if (us.getUsuario() == usuario && us.getClave() == clave)
                {
                    validado = true;
                    return validado;
                }
            }
            return validado;
        }

        public string RegistrarUsuario(string clave, string usuario)
        {
            using (IDbConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();

                try
                {
                    var values = new { clave = clave, usuario = usuario };
                    conexion.Query("_paRegistrarUsuario", values, commandType: CommandType.StoredProcedure);
                    return "Se registró correctamente!";
                }
                catch (Exception e)
                {
                    return "Hubo un error: " + e;
                }

            }
        }

    }
}
