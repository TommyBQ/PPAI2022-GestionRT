namespace PPAIGestionRecursosTecno2022.Models
{
    public class Sesion
    {
        private string descripcion { get; set; }
        private Usuario usuario { get; set; }

        public Sesion(string descripcion, Usuario usuario)
        {
            this.descripcion = descripcion;
            this.usuario = usuario;
        }

        public void conocerUsuario()
        {

        }
    }
}
