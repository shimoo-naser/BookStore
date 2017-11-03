using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDomain.Entities
{
   public  class Book
    {
        public int ISBN { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }


        public decimal Price { get; set; }


        public String Specialization { get; set; }


        public String Author { get; set; }
    }
}
