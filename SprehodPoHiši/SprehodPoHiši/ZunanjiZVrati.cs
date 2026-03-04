using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class ZunanjiZVrati : Zunanji, IZunanjaVrata
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
        public ZunanjiZVrati(string i, bool v, string a):base(i,v)
        {
            vrata = a;
        }
    }
}
