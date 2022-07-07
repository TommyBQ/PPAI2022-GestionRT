using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class SesionController : GenericController<Sesion>
    {
        public SesionController(IGenericService<Sesion> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
