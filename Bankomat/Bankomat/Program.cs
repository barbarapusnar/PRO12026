namespace Bankomat
{
    using System.Windows.Forms;
    internal class Program
    {
        static decimal stanje = 0;
        static decimal znesek = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Želiš opravlajti transakcije da/ne");
            string odg = Console.ReadLine();
            while (odg.ToUpper() == "DA")
            {
                Console.WriteLine("Kaj želiš? 1-dvig,2-polog,3-izpis stanja");
                int tip = int.Parse(Console.ReadLine());
                
                switch (tip)
                {
                    case 1:
                        Dvig();
                        break;
                    case 2:
                        Polog();
                        break;
                    case 3:
                        Izpis();
                        break;
                }
                Console.WriteLine("Želiš opravlajti transakcije da/ne");
                odg = Console.ReadLine();
            }
        }
        static void Dvig()
        {
            Console.WriteLine("Koliko boš dvignil?");
            znesek = decimal.Parse(Console.ReadLine());
            stanje -= znesek;
            Console.WriteLine("Novo stanje je " + stanje);
        }
        static void Polog()
        {
            Console.WriteLine("Koliko boš položil?");
            znesek = decimal.Parse(Console.ReadLine());
            stanje += znesek;
            Console.WriteLine("Novo stanje je " + stanje);
        }
        static void Izpis()
        {
            MessageBox.Show("Tvoje stanje je " + stanje + " EURO","Bankomat", MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }
    }
}
