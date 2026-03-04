namespace KalkulatorOcenV1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi oddelek študenta 1-ang,2-mat,3-nar");
            int oddelek = int.Parse(Console.ReadLine());
            switch (oddelek)
            {
                case 1:
                    break;
                case 2:
                    StudentMat m = new StudentMat();
                    Console.WriteLine("Vnesi delni 1");
                    m.Delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi delni 2");
                    m.Delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(m.Izpis());
                    break;
                case 3:
                    break;

            }
        }
    }
}
