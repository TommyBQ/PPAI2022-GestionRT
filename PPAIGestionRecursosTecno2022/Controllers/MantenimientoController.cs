using Microsoft.AspNetCore.Mvc;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class MantenimientoController : ControllerBase
    {
        [HttpGet]
        [Route("Saludar")]
        public string Hola()
        {
            return "Hola";
        }
    }
}
