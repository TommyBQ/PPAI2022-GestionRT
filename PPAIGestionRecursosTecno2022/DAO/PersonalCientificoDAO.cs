using Dapper;
using Microsoft.Data.SqlClient;
using PPAIGestionRecursosTecno2022.Models;
using System.Data;

namespace PPAIGestionRecursosTecno2022.DAO
{
    public class PersonalCientificoDAO
    {
        private string cadena { get { return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PPAI_2022;Integrated Security=True"; } }
        private UsuariosDAO usuariosDAO => new UsuariosDAO();

        public List<PersonalCientifico> GetAllPersonalCientifico()
        {
            List<PersonalCientifico> allPC = new List<PersonalCientifico>();
            using (IDbConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();

                var personalCientifico = conexion.Query("_paBuscarTodoPersonalCientifico", commandType: CommandType.StoredProcedure).ToList();

                if (personalCientifico != null)
                {
                    foreach (var pC in personalCientifico)
                    {
                        string legajo = (string)pC.Legajo;
                        string nombre = (string)pC.Nombre;
                        string apellido = (string)pC.Apellido;
                        string numeroDocumento = (string)pC.NumeroDocumento;
                        string correoInstitucional = (string)pC.CorreoInstitucional;
                        string correoPersonal = (string)pC.CorreoPersonal;
                        string telefono = (string)pC.Telefono;
                        int idUsuario = (int)pC.idUsuario;

                        Usuario usr = usuariosDAO.getUnUsuarioXId(idUsuario);

                        PersonalCientifico pc = new PersonalCientifico(legajo, nombre, apellido, numeroDocumento, correoInstitucional, correoPersonal, telefono, usr);
                        allPC.Add(pc);
                    }
                }
                return allPC;
            }
        }

        public PersonalCientifico getUnPersonalCientificoXId(string legajoPC)
        {
            using (IDbConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();

                try
                {
                    var values = new { Legajo = legajoPC };
                    var personalCientifico = conexion.Query("_paBuscarUnPersonalCientificoPorId", values, commandType: CommandType.StoredProcedure);
                    if (personalCientifico != null)
                    {
                        foreach (var pC in personalCientifico)
                        {
                            string legajo = (string)pC.Legajo;
                            string nombre = (string)pC.Nombre;
                            string apellido = (string)pC.Apellido;
                            string numeroDocumento = (string)pC.NumeroDocumento;
                            string correoInstitucional = (string)pC.CorreoInstitucional;
                            string correoPersonal = (string)pC.CorreoPersonal;
                            string telefono = (string)pC.Telefono;
                            int idUsuario = (int)pC.idUsuario;

                            //PersonalCientifico pcEncontrado = new PersonalCientifico(legajo, nombre, apellido, numeroDocumento, correoInstitucional, correoPersonal, telefono, idUsuario);
                            //return pcEncontrado;
                        }
                    }
                    return new PersonalCientifico();
                }
                catch (Exception e)
                {
                    throw new Exception("No se encontró Personal Cientifico");
                }

            }
        }
    }
}
