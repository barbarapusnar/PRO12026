namespace Metode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Izpiši();
            //int x=Izpiši1();
            //Console.WriteLine("Metoda je vrnila "+x);
            //Console.WriteLine("Druga možnost "+Izpiši1());
            Izpiši("Alenka");
            Izpiši("Miha");
            //Console.WriteLine("Vnesi svoje ime");
            //string mojeIme = Console.ReadLine();
            //Izpiši(mojeIme,"Lepo ime");
            Izpiši(5);
           // int z = int.Parse(Console.ReadLine());
            
        }
        static void Izpiši(string ime, string kakoSi)
        {
            Console.WriteLine("Pozdravljen/a "+ime);
            Console.WriteLine(kakoSi);
        }
        static void Izpiši(string ime)
        {
            Console.WriteLine("Kako si, "+ime+"?");
        }
        static void Izpiši(int x)
        {
            Console.WriteLine("Vrednost x ="+x);
        }
        //static void Izpiši(int y)  NAROBE ni overload metode
        //{
        //    Console.WriteLine("Vrednost x =" + x);
        //}
        //static void Izpiši()
        //{
        //    Console.WriteLine("Pozdravljen svet");
        //    return;
        //}
        //static int Izpiši1()
        //{
        //    Console.WriteLine("Pozdravljen svet");
        //    return 1;
        //}
    }
}
