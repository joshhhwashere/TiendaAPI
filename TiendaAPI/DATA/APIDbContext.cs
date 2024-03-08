using Microsoft.EntityFrameworkCore;
using TiendaAPI.MODELS;

namespace TiendaAPI.DATA
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Películas> Películas{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var peli1 = new Películas() { ID = 1, Nombre = "Data Seed1", Género = "Acción", Duración = "2 horas 30 minutos", Precio = 2.50, Director = "Christopher Nolan" };
            var peli2 = new Películas() { ID = 2, Nombre = "Data Seed2", Género = "Comedia", Duración = "2 horas 15 minutos", Precio = 3.00, Director = "Quentin Tarantino" };
            var peli3 = new Películas() { ID = 3, Nombre = "Data Seed3", Género = "Drama", Duración = "2 horas 45 minutos", Precio = 2.75, Director = "Martin Scorsese" };
            var peli4 = new Películas() { ID = 4, Nombre = "Data Seed4", Género = "Ciencia Ficción", Duración = "2 horas 20 minutos", Precio = 2.90, Director = "James Cameron" };
            var peli5 = new Películas() { ID = 5, Nombre = "Data Seed5", Género = "Romance", Duración = "2 horas", Precio = 2.80, Director = "Greta Gerwig" };
            var peli6 = new Películas() { ID = 6, Nombre = "Data Seed6", Género = "Suspense", Duración = "2 horas 10 minutos", Precio = 3.20, Director = "Alfred Hitchcock" };
            var peli7 = new Películas() { ID = 7, Nombre = "Data Seed7", Género = "Fantasía", Duración = "2 horas 5 minutos", Precio = 2.60, Director = "Tim Burton" };
            var peli8 = new Películas() { ID = 8, Nombre = "Data Seed8", Género = "Aventura", Duración = "2 horas 40 minutos", Precio = 3.10, Director = "Steven Spielberg" };
            var peli9 = new Películas() { ID = 9, Nombre = "Data Seed9", Género = "Misterio", Duración = "2 horas 25 minutos", Precio = 2.95, Director = "David Fincher" };
            var peli10 = new Películas() { ID = 10, Nombre = "Data Seed10", Género = "Animación", Duración = "2 horas 50 minutos", Precio = 3.05, Director = "Hayao Miyazaki" };


            modelBuilder.Entity<Películas>().HasData(new Películas[] { peli1, peli2, peli3, peli4, peli5, peli6, peli7, peli8, peli9, peli10 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
