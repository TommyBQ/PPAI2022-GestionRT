using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class RecursoTecnologicoController : GenericController<RecursoTecnologico>
    {
        public RecursoTecnologicoController(IGenericService<RecursoTecnologico> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
