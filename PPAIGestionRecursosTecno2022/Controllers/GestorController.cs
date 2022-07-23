using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Gestor;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GestorController : Controller
    {
        [HttpGet]
        public string Saludar()
        {
            return "Hola manola";
        }

        [HttpGet]
        public IActionResult buscarRecursosDelResponsable()
        {
            return Ok(GestorMantenimiento.GetInstanceGestor.buscarRecursosDelResponsable());
        }
    }
}
