namespace PPAIGestionRecursosTecno2022.Models
{
    public class Usuario
    {
        private string clave { get; set; }
        private string usuario { get; set; }
        private int id_usuario { get; set; }
        private bool habilitado { get; set; }

        public Usuario(string clave, string usuario, int idUsuario, bool habilitado)
        {
            this.clave = clave;
            this.usuario = usuario;
            this.id_usuario = idUsuario;
            this.habilitado = habilitado;
        }

        public string getUsuario()
        {
            return this.usuario;
        } 
        
        public string getClave()
        {
            return this.clave;
        }
    }
}
