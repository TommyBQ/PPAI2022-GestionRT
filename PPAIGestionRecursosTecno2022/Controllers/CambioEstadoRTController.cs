using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class CambioEstadoRTController : GenericController<CambioEstadoRT>
    {
        public CambioEstadoRTController(IGenericService<CambioEstadoRT> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
