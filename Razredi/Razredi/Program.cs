namespace Razredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Študent marija = new Študent();
            marija.Ime = "Marija Šarapova";
            marija.Starost =-3;
            Console.WriteLine(marija.PovprečnaOcena) ;
            marija.Izpis();
        }

    }
}
