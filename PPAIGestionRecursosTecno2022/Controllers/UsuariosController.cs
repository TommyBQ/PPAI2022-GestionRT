using Microsoft.AspNetCore.Mvc;
using PPAIGestionRecursosTecno2022.Models;
using PPAIGestionRecursosTecno2022.Services;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsuariosController : GenericController<Usuario>
    {
        public UsuariosController(IGenericService<Usuario> repoGenerico) : base(repoGenerico)
        {

        }

        [HttpGet]
        public IActionResult Login(string nombreUsuario, string password)
        {
            SessionManager.Login(UsuarioService.GetInstance.GetByNameAndPassword(nombreUsuario, password));
            return Ok("Se inició correctamente la sesión! :D");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            SessionManager.Logout();
            return Ok("Se cerró la sesión correctamente.");
        }
    }
}
