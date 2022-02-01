using System;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
namespace ModeloDB


{
    public class ListadoDB : DbContext
    {
    
            public DbSet<Category> categories { get; set; }
            public DbSet<Film_category> filmCategories { get; set; }
            public DbSet<Film> films { get; set; }


        //Configuracion de la conexion
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-D9M3GKJ; Initial Catalog=SGT; trusted_connection = true;");
        }

        ////Configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Relacion de de uno a muchos
            //una category tiene muchas film_category

            model.Entity<Film_category>()
                .HasOne(filmCategory => filmCategory.Category)
                .WithMany(category => category.Film_category)
                .HasForeignKey(filmCategory => filmCategory.CategoryId);



            //un film tiene muchos film_category
            model.Entity<Film_category>()
                .HasOne(filmCategory => filmCategory.Film)
                .WithMany(film => film.Film_category)
                .HasForeignKey(filmCategory => filmCategory.FilmId);

        }
    }
    }
    
