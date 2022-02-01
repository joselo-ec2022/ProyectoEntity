using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Film_category
    {
        public int Film_categoryId { get; set; }
        public DateTime Last_update { get; set; }


        //-------------------------------------
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Film Film { get; set; }
        public int FilmId { get; set; }




    }
}
