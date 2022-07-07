using Microsoft.AspNetCore.Mvc;

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
    }
}
