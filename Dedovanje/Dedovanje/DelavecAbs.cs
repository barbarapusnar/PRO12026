using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal abstract class DelavecAbs //samo za dedovanje
    {
        protected string delID;
        protected string ime;
        public string DelID { get => delID; set => delID = value; }
        public string Ime { get => ime; set => ime = value; }
        public abstract double BruotPlača { get; }
        public abstract void Izpis();
        public DelavecAbs(string d,string i)
        {
            Console.WriteLine("Konstruktor abstrakrnega razreda");
            delID = d;
            ime = i;
        }
    }
}
