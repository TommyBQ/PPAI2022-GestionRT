using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class TipoRTController : GenericController<TipoRT>
    {
        public TipoRTController(IGenericService<TipoRT> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
