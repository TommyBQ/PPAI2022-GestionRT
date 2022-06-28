namespace PPAIGestionRecursosTecno2022.Models
{
    public class Usuario
    {
        private string clave { get; set; }
        private string usuario { get; set; }
        private int IdUsuario { get; set; }
        private bool habilitado { get; set; }

        public Usuario(string clave, string usuario, int idUsuario, bool habilitado)
        {
            this.clave = clave;
            this.usuario = usuario;
            this.IdUsuario = idUsuario;
            this.habilitado = habilitado;
        }

        public void getUsuario()
        {

        }
    }
}
