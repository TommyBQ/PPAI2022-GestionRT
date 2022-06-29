using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PPAIGestionRecursosTecno2022.DAO;
using PPAIGestionRecursosTecno2022.Models;
using System.Data;

namespace PPAIGestionRecursosTecno2022.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MantenimientoRTController : ControllerBase
    {
        private readonly IConfiguration _configuration;

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
        [Route("ValidarUsuario")]
        public bool ValidarUsuario(string usuario, string clave)
        {
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            bool response = usuariosDAO.ValidarUsuario(usuario, clave);
            return response;
        }
    }
}
