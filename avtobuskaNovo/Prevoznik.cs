using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtobuskaNovo
{
    public class Prevoznik
    {
        public string ime { get; set; }
        public string mesto { get; set; }

        public Prevoznik(string i, string m)
        {
            ime = i;
            mesto = m;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", ime, mesto);
        }
    }
}
