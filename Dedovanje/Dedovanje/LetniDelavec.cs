using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class LetniDelavec : DelavecAbs
    {
        double letnaPlača;
        public double LetnaPlača { get => letnaPlača; set => letnaPlača = value; }
        public override double BruotPlača
        {
            get { return letnaPlača / 12; }
        }

        

        public override void Izpis()
        {
            Console.WriteLine("Del id " + delID);
            Console.WriteLine("Ime    " + ime);
            Console.WriteLine("Letna plača " + letnaPlača);
            Console.WriteLine("Bruto plača " + BruotPlača);
            Console.WriteLine("************************");
        }
    }
}
