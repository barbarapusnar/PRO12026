using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi
{
    internal class Študent
    {
        private string telefon;
        private string ime;
        //javna lastnost
        public string Ime
        {
            get {
                return ime;
            }
            set {
                ime = value;
            }
        }
        private int starost;
        public int Starost
        {
            get { return starost; }
            set {
                if (value >= 15 && value >= 30)
                    starost = value;
                else
                    starost = 0;
            }
        }
        private double povprečnaOcena;
        public double PovprečnaOcena 
        { get => povprečnaOcena;}
        public string Telefon 
        { 
            get { return telefon; }
            set { telefon = value; } 
        }

        public Študent()
        {
            ime = "Marija Novak";
            starost = 19;
            povprečnaOcena = 7.5;
        }
        public void Izpis()
        {
            Console.WriteLine("Ime             "+ime);
            Console.WriteLine("Starost         "+starost);
            Console.WriteLine("Povprečna ocena "+povprečnaOcena);
        }
    }
}
