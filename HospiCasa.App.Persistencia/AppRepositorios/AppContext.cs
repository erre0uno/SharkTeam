using Microsoft.EntityFrameworkCore;
using HospiCasa.App.Dominio;

namespace HospiCasa.App.Persistencia
{

    public class AppContext : DbContext
    {

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Enfermero> Enfermeros { get; set; }
        public DbSet<Familiar> Familiares { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Signovital> Signosvitales { get; set; }
        public DbSet<Sugerencia> Sugerencias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = TestData2");
            }
        }


    }

}

/*
dotnet  add reference ..\HospiCasa.App.Dominio\
adiiciona al alrchivo de configuracion en persistencia.csproj
la ruta del dominio de la app

*/
