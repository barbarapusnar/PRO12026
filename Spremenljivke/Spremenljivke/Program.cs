namespace Spremenljivke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            double c = 2.5;
            float c1 = (float)2.5;
            decimal c2 = (decimal)2.5;
            short d = (short)a;
            char znak = 'A';
            int ascii = znak;
            Console.WriteLine("ASCII koda od A ="+ascii);
            znak = (char)42;
            Console.WriteLine("Pod 42 se skriva "+znak);
        }
    }
}
