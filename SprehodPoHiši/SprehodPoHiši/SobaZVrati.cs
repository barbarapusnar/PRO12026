using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class SobaZVrati : Soba, IZunanjaVrata
    {
        string vrata;
        public Lokacija lok;

        public Lokacija lokacijaVrat()
        {
            return lok;   
        }

        public string OpisVrat()
        {
            return vrata;
        }
        public SobaZVrati(string i,string d,string v):base(i,d)
        {
            vrata = v;
        }
    }
}
