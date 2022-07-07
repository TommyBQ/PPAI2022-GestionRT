using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class ModeloController : GenericController<Modelo>
    {
        public ModeloController(IGenericService<Modelo> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
