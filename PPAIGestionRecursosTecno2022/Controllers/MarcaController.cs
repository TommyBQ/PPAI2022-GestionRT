using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class MarcaController : GenericController<Marca>
    {
        public MarcaController(IGenericService<Marca> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
