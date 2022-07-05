using Dapper;
using Microsoft.Data.SqlClient;
using PPAIGestionRecursosTecno2022.Models;
using System.Data;

namespace PPAIGestionRecursosTecno2022.DAO
{
    public class RecursoTecnologicoDAO
    {
        private string cadena { get { return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PPAI_2022;Integrated Security=True"; } }

        public List<RecursoTecnologico> GetAllRecursosTecnologicos()
        {
            List<RecursoTecnologico> allRT = new List<RecursoTecnologico>();
            using (IDbConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();

                var recTecnologicos = conexion.Query("_paBuscarTodoRecursosTecnologicos", commandType: CommandType.StoredProcedure).ToList();

                if (recTecnologicos != null)
                {
                    foreach (var rts in recTecnologicos)
                    {
                        int numRT = (int)rts.id_RecursoTecnologico;
                        string nombreRT = (string)rts.clave;
                        DateTime? fechaAlta = (DateTime?)rts.RecursoTecnologico;
                        string? imagen = (string?)rts.habilitado;
                        int idTipoRT = (int)rts.habilitado;
                        int idModelo = (int)rts.habilitado;
                        int? idTurno = (int?)rts.habilitado;
                        int idCambioEstadoRT = (int)rts.habilitado;
                        int? idMantenimiento = (int?)rts.habilitado;

                        //RecursoTecnologico rtAAgregar = new RecursoTecnologico();
                        //allRT.Add(rtAAgregar);
                    }
                }
                return allRT;
            }
        }
    }
}
