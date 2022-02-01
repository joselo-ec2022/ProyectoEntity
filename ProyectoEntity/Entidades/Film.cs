using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Film
    {
        public int FilmId { get; set; }
        public String Title { get; set; }
        public String Desciption { get; set; }
        public int RelaseYear { get; set; }

        public double RentalDuracion { get; set; }
        public double RentalRate { get; set; }
        public double Lenght { get; set; }
        public double Rating { get; set; }
        public DateTime Last_update { get; set; }

        public String SpecialFeatures { get; set; }


        //-----------------------------------

        public List<Film_category> Film_category { get; set; }



    }
}
