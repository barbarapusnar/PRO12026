using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PrimeriRazredov
{
    internal class Avto
    {

        int največjaHitrost;
        double povprečnaPoraba;
        double količiniaGoriva;
        int številoPrevoženih;
        string regŠt;
        public Avto(string r,int n,double p) //nov avto
        {
            največjaHitrost = n;
            povprečnaPoraba = p;
            regŠt = r;
            številoPrevoženih = 0;
            količiniaGoriva = 0;
        }
        public Avto(string r,int n,double p,double k,int š)
        {
            največjaHitrost = n;
            povprečnaPoraba = p;
            regŠt = r;
            številoPrevoženih = š;
            količiniaGoriva = k;
        }
        public void Izpis()
        {
            Console.WriteLine("*******AVTO**********");
            Console.WriteLine("Registrska številka   "+regŠt);
            Console.WriteLine("Največja hitrost      "+največjaHitrost);
            Console.WriteLine("Povprečna poraba      "+povprečnaPoraba);
            Console.WriteLine("Število prevoženih km "+številoPrevoženih);
            Console.WriteLine("Količina goriva       "+količiniaGoriva);
            Console.WriteLine("********************");
        }
        public double Doseg()
        {
            return količiniaGoriva * 100 / povprečnaPoraba;
        }
        public int NaslednjiServis(int n)
        {
            return n - številoPrevoženih % n;
        }
    }
}
