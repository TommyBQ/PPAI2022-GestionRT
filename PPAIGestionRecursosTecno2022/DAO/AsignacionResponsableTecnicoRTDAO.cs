using Dapper;
using Microsoft.Data.SqlClient;
using PPAIGestionRecursosTecno2022.Models;
using System.Data;

namespace PPAIGestionRecursosTecno2022.DAO
{
    public class AsignacionResponsableTecnicoRTDAO
    {
        private string cadena { get { return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PPAI_2022;Integrated Security=True"; } }
        private PersonalCientificoDAO personalCientificoDAO => new PersonalCientificoDAO();

        public List<AsignacionResponsableTecnicoRT> GetAllAsignacionResponsableTecnicoRT()
        {
            List<AsignacionResponsableTecnicoRT> allAsignaciones = new List<AsignacionResponsableTecnicoRT>();
            using (IDbConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();

                var AsignacionResponsableTecnicoRT = conexion.Query("_paBuscarTodoAsignacionResponsableTecnicoRT", commandType: CommandType.StoredProcedure).ToList();

                if (AsignacionResponsableTecnicoRT != null)
                {
                    foreach (var asignacion in AsignacionResponsableTecnicoRT)
                    {
                        int idAsignacion = (int)asignacion.IdAsignacionResponsableTecnicoRT;
                        DateTime fechaDesde = (DateTime)asignacion.FechaDesde;
                        DateTime? fechaHasta = (DateTime?)asignacion.FechaHasta;
                        int idRT = (int)asignacion.IdRecursoTecnologico;
                        string legajoPC= (string)asignacion.LegajoPersonalCientifico;

                        PersonalCientifico cientifico = personalCientificoDAO.getUnPersonalCientificoXId(legajoPC);

                        AsignacionResponsableTecnicoRT asignacionAGuardar = new AsignacionResponsableTecnicoRT(fechaDesde, fechaHasta, cientifico);

                        allAsignaciones.Add(asignacionAGuardar);
                    }
                }
                return allAsignaciones;
            }
        }
    }
}
