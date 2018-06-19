using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtobuskaNovo
{
   public class Bilet
    {
        public Relacii relacija { get; set; }
        //tip==1 eden pravec   tip==2 povraten bilet
        public int tip { get; set; }
        public string cas { get; set; }
        public Prevoznik prevoznik { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} , cena: {2} denari", relacija.od, relacija.doo, relacija.cena);
        }
    }
}
