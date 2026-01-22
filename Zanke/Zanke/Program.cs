namespace Zanke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dvigalo se ustavi v ");
            //int k = 0;
            //for (int k = 1; k < 10; k++)
            //{
            //    Console.WriteLine(k+". nadstropju");
            //}
            //Console.WriteLine("Zadnje nadstropje "+k);
            //int števec = 10;
            //while (števec < 10)
            //{
            //    Console.WriteLine(števec + ". nadstropju");
            //    števec++;
            //}
            int števec = 10;
            do
            {
                Console.WriteLine(števec+". nadstropju");
                števec++;
            } while (števec < 10);
        }
    }
}
