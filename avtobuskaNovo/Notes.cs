using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtobuskaNovo
{
   public class Notes
    {
        public string note { get; set; }

        public Notes(string n)
        {
            note = n;
        }

        public override string ToString()
        {
            return string.Format("{0}", note);
        }
    }
}
