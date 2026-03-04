using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Lokacija
    {
        public string ime;
        public Lokacija[] izhodi;
        public Lokacija(string i)
        {
            ime = i;
            //izhodi = new Lokacija[10]; //inicializacija tabele
        }
        public string Opis()
        {
            string s = "Trenutno si v "+ime+Environment.NewLine;
            s += "Od tu lahko greš: ";
            for (int k = 0; k < izhodi.Length; k++)
            {
                s += k + " - " + izhodi[k].ime+ Environment.NewLine;
            }
            return s;
        }
    }
}
