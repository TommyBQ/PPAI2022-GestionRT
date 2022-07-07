using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class EstadoController : GenericController<Estado>
    {
        public EstadoController(IGenericService<Estado> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
