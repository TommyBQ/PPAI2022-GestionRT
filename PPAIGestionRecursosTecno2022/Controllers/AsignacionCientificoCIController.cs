using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class AsignacionCientificoCIController : GenericController<AsignacionCientificoCI>
    {
        public AsignacionCientificoCIController(IGenericService<AsignacionCientificoCI> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
