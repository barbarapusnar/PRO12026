using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeriRazredov
{
    internal class Oseba
    {
        int starost;
        string ime;
        public Oseba(int s, string i)
        {
            starost = s;
            ime = i;
        }
        public int GetAgeInMonths()
        {
            return starost * 12;
        }
        public bool IsAdult()
        {
            if (starost >= 18)
                return true;
            return false;
        }
        public bool IsEqual(Oseba x)
        {
            if (this.starost == x.starost && this.ime == x.ime)
                return true;
            return false;
        }
        
    }
}
