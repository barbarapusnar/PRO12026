using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Soba:Lokacija
    {
        public string dekoracija;
        public Soba(string i,string d):base(i)
        {
            dekoracija = d;
        }
        public new string Opis()
        {
            string r = base.Opis();
            r += Environment.NewLine + "Vidiš " + dekoracija;
            return r;
        }
    }
}
