using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
   public class Category
    {
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public DateTime Last_update { get; set; }

        //-----------------------------------

        public List<Film_category> Film_category { get; set; }
    }
}
