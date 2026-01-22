namespace Vnosi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Koliko si star?");
            //int leta = int.Parse(Console.ReadLine());
            //if (leta>=65)
            //    Console.WriteLine("Moraš se upokojiti");
            //else
            //    if (leta==64)
            //     Console.WriteLine("Še eno leto");
            //    else
            //       if (leta==63)
            //         Console.WriteLine("Še dve leti");
            //       else
            //          if (leta==62)
            //             Console.WriteLine("Še tri leta");
            //          else
            //            Console.WriteLine("Še dolgo boš delal");
            //switch
            Console.WriteLine("Vnesi število med 1 in 3");
            int št = int.Parse(Console.ReadLine());
            switch (št)
            {
                case 1:
                    Console.WriteLine("Vneseli si 1");
                    break;
                case 2:
                    Console.WriteLine("Vnesel si 2");
                    break;
                case 3:
                    Console.WriteLine("Vnesel si 3");
                    break;
                default:
                    Console.WriteLine("Število ni med 1 in 3");
                    break;
            }
        }
    }
}
