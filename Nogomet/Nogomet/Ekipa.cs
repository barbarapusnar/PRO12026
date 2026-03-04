using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogomet
{
    internal class Ekipa
    {
        public string Ime { get; set; }
        public int DaniGoli { get; set; }
        public int PrejetiGoli { get; set; }
        public int ŠtTekem { get; set; }
        public int ŠtZmag { get; set; }
        public int ŠtNeodločenih { get; set; }
        public Ekipa(string i)
        {
            Ime = i;
        }
        public void VnesiRezultat(int d, int p) 
            //vnesi rezultat za to ekipo, če je na tekmi dala d golov in prejela p golov
        {
            ŠtTekem++;
            DaniGoli += d;
            PrejetiGoli += p;
            if (d > p)
            {
                ŠtZmag++;
            }
            else
            {
                if (d == p)
                {
                    ŠtNeodločenih++;
                }
            }
        }
        public int ŠteviloTočk()
        {
            return ŠtZmag * 3 + ŠtNeodločenih;
        }
        public int GolRazlika()
        {
            return DaniGoli - PrejetiGoli;
        }
        public string Izpis()
        {
            return Ime + "\t" + ŠtTekem + "\t" + ŠteviloTočk() + "\t" + GolRazlika() + "\t" + DaniGoli;
        }
        public bool BoljšaEkipa(Ekipa x)
        {
            if (this.ŠteviloTočk() > x.ŠteviloTočk())
            {
                return true;
            }
            if (this.ŠteviloTočk() == x.ŠteviloTočk() && this.GolRazlika() > x.GolRazlika())
            {
                return true;
            }
            if (this.ŠteviloTočk()==x.ŠteviloTočk() 
                && this.GolRazlika()==x.GolRazlika()
                && this.DaniGoli>x.DaniGoli)
            {
                return true;
            }
            return false;
        }
    }
}
