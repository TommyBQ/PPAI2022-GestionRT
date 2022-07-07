using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    public class MantenimientoController : GenericController<Mantenimiento>
    {
        public MantenimientoController(IGenericService<Mantenimiento> repoGenerico) : base(repoGenerico)
        {
        }
    }
}
