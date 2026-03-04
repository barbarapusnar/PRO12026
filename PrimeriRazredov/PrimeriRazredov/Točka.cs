using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeriRazredov
{
    internal class Točka
    {
        double x;
        double y;
        double r;
        int kot;
        public Točka(double x1, double y1)
        {
            x = x1;y = y1;
            IzKvP();
        }
        public Točka(double r1,int k)
        {
            r = r1;kot = k;
            IzPvK();
        }
        public void Izpis()
        {
            Console.WriteLine("Kartezične:  ("+x+" ,"+y+")");
            Console.WriteLine("Polarne   :  ("+r+" ,"+kot+")");
        }
        public void IzKvP()
        {
            //x,y poznam, računam r in kot
            r = Math.Sqrt(x * x + y * y);
            kot = (int)(Math.Atan(y / x)*180/Math.PI);
        }
        public void IzPvK()
        {
            //r in kot poznam, računam x in y
            x = r * Math.Cos(kot * Math.PI / 180);
            y = r * Math.Sin(kot * Math.PI / 180);
        }
    }
}
