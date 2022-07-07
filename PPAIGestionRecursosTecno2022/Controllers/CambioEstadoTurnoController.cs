using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class CambioEstadoTurnoController : GenericController<CambioEstadoTurno>
    {
        public CambioEstadoTurnoController(IGenericService<CambioEstadoTurno> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
