using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class AsignacionResponsableTecnicoRTController : GenericController<AsignacionResponsableTecnicoRT>
    {
        public AsignacionResponsableTecnicoRTController(IGenericService<AsignacionResponsableTecnicoRT> repoGenerico) : base(repoGenerico)
        {
        }

    }
}
