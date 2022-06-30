using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PPAIGestionRecursosTecno2022.DAO;
using PPAIGestionRecursosTecno2022.Gestor;
using PPAIGestionRecursosTecno2022.Models;
using PPAIGestionRecursosTecno2022.Exceptions;
using System.Data;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MantenimientoRTController : ControllerBase
    {
        public GestorMantenimiento gestorMantenimiento;
        private UsuariosDAO usuariosDAO => new UsuariosDAO();

        public MantenimientoRTController()
        {
            this.gestorMantenimiento = new GestorMantenimiento();
        }

        [HttpGet]
        [Route("Saludar")]
        public string Hola()
        {
            return "Hola manola";
        }

        [HttpGet]
        [Route("RegistrarUsuario")]
        public string RegistrarUsuario(string usuario, string clave)
        {
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            string response = usuariosDAO.RegistrarUsuario(usuario, clave);
            return response;
        }

        [HttpGet]
        [Route("IniciarSesion")]
        public IActionResult IniciarSesion(string usuario, string clave)
        {
            bool usuarioValidado = usuariosDAO.ValidarUsuario(usuario, clave);
            if (!usuarioValidado)
            {
                return BadRequest("No se pudo iniciar sesión. Usuario o contraseña incorrecto!");
            }
            Usuario usuarioIniciado = usuariosDAO.getUnUsuario(usuario);
            Sesion sesion = new Sesion("Sesion del usuario: " + usuario, usuarioIniciado);

            gestorMantenimiento.Sesion = sesion;
            return Ok(sesion);
        }
    }
}
