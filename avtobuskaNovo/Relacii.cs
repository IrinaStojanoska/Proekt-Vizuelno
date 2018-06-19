using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtobuskaNovo
{
   public  class Relacii
    {
        public string od { get; set; }
        public string doo { get; set; }
        public int km { get; set; }
        public int cena{ get; set; }
       
        public Relacii (string pocetok, string kraj, int c)
        {
            od = pocetok;
            doo = kraj;
            cena = c;
          
        }


        public override string ToString()
        {
            return string.Format("{0} - {1} {2} денари ", od, doo, cena);
        }
    }
}
