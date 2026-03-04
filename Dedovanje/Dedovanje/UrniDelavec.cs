using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class UrniDelavec : DelavecAbs
    {
        int ŠtUr;
        double urnaPostavka;
        public int ŠtUr1 { get => ŠtUr; set => ŠtUr = value; }
        public double UrnaPostavka { get => urnaPostavka; set => urnaPostavka = value; }
        public override double BruotPlača
        {
            get { return ŠtUr * urnaPostavka; }
        }
        public UrniDelavec(string d,string i, int š,int u):base(d,i)
        {
            Console.WriteLine("Konstruktor UrniDelavec");
            ŠtUr = š;
            urnaPostavka = u;
        }


        public override void Izpis()
        {
            Console.WriteLine("Del id " + delID);
            Console.WriteLine("Ime    " + ime);
            Console.WriteLine("Št. ur " + ŠtUr);
            Console.WriteLine("Na uro " + urnaPostavka + " EURO");
            Console.WriteLine("Bruto plača " + BruotPlača);
            Console.WriteLine("************************");
        }
    }
}
