using Microsoft.EntityFrameworkCore;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class AppContext : DbContext 
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ganadero> Ganaderos { get; set; }
        public DbSet <Ejemplares> Ejemplares {get; set;}
        public DbSet<Finca> Finca {get; set;}
        public DbSet<HistoriaClinica> HistoriaClinica { get; set;}
        public DbSet<Solicitud> Solicitud {get; set;}
        public DbSet<Vacunas> Vacunas {get; set;}
        public DbSet<Veterinario> Veterinario {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=Grupo31");
            }
        }
    }
}