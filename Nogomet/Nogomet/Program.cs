namespace Nogomet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ekipa a = new Ekipa("Slovenija");
            Ekipa b = new Ekipa("Italija  ");
            a.VnesiRezultat(3, 2);
            b.VnesiRezultat(2, 3);
            Console.WriteLine(a.Izpis());
            Console.WriteLine(b.Izpis());
            Console.WriteLine(a.Ime+" je boljša od "+b.Ime+"? "+a.BoljšaEkipa(b));
        }
    }
}
