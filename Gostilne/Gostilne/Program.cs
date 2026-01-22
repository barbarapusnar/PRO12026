namespace Gostilne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime danes = DateTime.Now;
            if (danes.DayOfWeek==DayOfWeek.Monday )
               Console.WriteLine("Jej pri Janezu!");
            if (danes.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Jej pri Micki!");
               
            }
            if (danes.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Jej pri Tonetu!");
                Console.WriteLine("Dober tek");
            }
            if (danes.DayOfWeek == DayOfWeek.Thursday)
                Console.WriteLine("Jej pri Bricu!");
            if (danes.DayOfWeek == DayOfWeek.Friday)
                Console.WriteLine("Jej pri Kenu!");
            if (danes.DayOfWeek == DayOfWeek.Saturday)
                Console.WriteLine("Jej pri Marjanu!");
            if (danes.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("Jej pri Francu!");
            int x = 7;
            if (x == 5)
            {
                Console.WriteLine("Je enako 5");
            }
            else
            {
                Console.WriteLine("Ni enako 5");
            }
        }
    }
}
