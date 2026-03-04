using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi
{
    internal class Napis
    {
        public string najljubšiProgram; //atribut razreda
        public static int številoIzvodov;
        //obnašanje
        public void Izpiši()
        {
            Console.WriteLine("Rad imam "+najljubšiProgram);
        }
        //konstruktor
        public Napis()
        {
            Console.WriteLine("Sem v konstruktorju");
            najljubšiProgram = "neznano";
            številoIzvodov++;
        }
        public Napis(string jezik)
        {
            Console.WriteLine("Sem v drugem konstruktorju");
            najljubšiProgram = jezik;
            številoIzvodov++;
        }
        public void Koliko()
        {
            Console.WriteLine("Število izvodov je "+številoIzvodov);
        }
        ~Napis()
        {
            Console.WriteLine("Destruktor napisa");
        }
    }
}
