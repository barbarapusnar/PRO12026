using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Delavec
    {
        protected string delID;
        protected string ime;
        private double štUr;
        private double urnaPostavka;
        protected double brutoPlača;

        public string DelID { get => delID; set => delID = value; }
        public string Ime { get => ime; set => ime = value; }
        public double ŠtUr { get => štUr; set => štUr = value; }
        public double UrnaPostavka { get => urnaPostavka; set => urnaPostavka = value; }
        public double BrutoPlača 
        { get
            { return urnaPostavka * štUr; }
        }
        public Delavec()
        {
            Console.WriteLine("Konstruktor delavec");
        }
        public void Izpis()
        {
            Console.WriteLine("Del id "+delID);
            Console.WriteLine("Ime    "+ime);
            Console.WriteLine("Št. ur "+štUr);
            Console.WriteLine("Na uro "+urnaPostavka+" EURO");
            Console.WriteLine("Bruto plača "+BrutoPlača);
            Console.WriteLine("************************");
        }
    }
}
