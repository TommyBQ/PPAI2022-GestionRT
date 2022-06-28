namespace PPAIGestionRecursosTecno2022.Models
{
    public class PersonalCientifico
    {
        private int legajo { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string correo { get; set; }

        public PersonalCientifico(int legajo, string nombre, string apellido, string correo)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
        }

        public void esTuUsuario()
        {

        }
    }
}
