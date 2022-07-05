using Microsoft.EntityFrameworkCore;
using PPAIGestionRecursosTecno2022.Models;

namespace PPAIGestionRecursosTecno2022
{
    public class GestionRTContext : DbContext
    {
        public GestionRTContext(DbContextOptions<GestionRTContext> options) 
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sesion> Sesion { get; set; }
        public DbSet<PersonalCientifico> PersonalCientifico { get; set; }
    }
}
