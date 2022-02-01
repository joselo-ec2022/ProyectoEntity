using System;
using ModeloDB;
using Modelo.Entidades;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Category Terror = new Category()
            {
                Name="Terror",
                Last_update = new DateTime(2021, 12, 12)
            };



            Category Accion = new Category()
            {
                Name = "Accion",
                Last_update = new DateTime(2020, 02, 25)
            };



            Category Comedia = new Category()
            {
                Name = "Comedia",
                Last_update = new DateTime(2020, 09, 19)
            };


            List<Category> listacategory = new List<Category>() {
                Terror, Accion, Comedia};


            //-----------------------------------------------------

            Film Batman = new Film()
            {
                Title = "Batman",
                Desciption = "Justiciero",
                RelaseYear = 2008,
                RentalDuracion = 190.59,
                RentalRate = 4.4,
                Lenght = 1.30,
                Rating = 4.3,
                Last_update = new DateTime(2020, 09, 19),
                SpecialFeatures = "Hollywod"
               
    };


            Film Agent007 = new Film()
            {
                Title = "Agent007",
                Desciption = "Secret Agent",
                RelaseYear = 1999,
                RentalDuracion = 120.00,
                RentalRate = 4.0,
                Lenght = 1.00,
                Rating = 4.9,
                Last_update = new DateTime(2010, 02, 01),
                SpecialFeatures = "Hollywod"

            };


            Film Barbie = new Film()
            {
                Title = "Barbie",
                Desciption = "Teen Adventure",
                RelaseYear = 2005,
                RentalDuracion = 80.19,
                RentalRate = 3.5,
                Lenght = 1.20,
                Rating = 3.3,
                Last_update = new DateTime(2010, 10, 15),
                SpecialFeatures = "Indie"

            };

            List<Film> listafilms = new List<Film>() {
                Batman, Agent007, Barbie};



            //-------------------------------------------------


            Film_category Ninios = new Film_category()
            {
                Last_update = new DateTime(2010, 10, 15)
            };

            Film_category Jovenes = new Film_category()
            {
                Last_update = new DateTime(2020, 09, 19)
            };

            Film_category Adultos = new Film_category()
            {
                Last_update = new DateTime(2010, 02, 01)
            };

            Film_category Todopublico = new Film_category()
            {
                Last_update = new DateTime(2010, 10, 15)
            };

            Film_category Estrenos = new Film_category()
            {
                Last_update = new DateTime(2020, 09, 19)
            };



            List<Film_category> listafilmCategory = new List<Film_category>() {
                Ninios, Jovenes, Adultos, Todopublico, Estrenos};





            ListadoDB db = new ListadoDB();
            db.categories.AddRange(listacategory);
            db.films.AddRange(listafilms);
            db.filmCategories.AddRange(listafilmCategory);

            db.SaveChanges();

        }
    }
}
