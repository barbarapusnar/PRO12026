using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Zunanji:Lokacija
    {
        public bool vroče;
        public Zunanji(string i,bool v):base(i)
        {
            vroče = v;
        }
        public new string Opis()
        {
            string r = base.Opis();
            r += "Je vroče? " + vroče;
            return r;
        }
    }
}
