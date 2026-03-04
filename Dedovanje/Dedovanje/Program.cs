namespace Dedovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UrniDelavec u = new UrniDelavec("123","Janez Novak",168,10);
            u.Izpis();
            // NAROBE!!!!
            //DelavecAbs d = new DelavecAbs();
            //DelavecAbs d;
            //d = new UrniDelavec();
            //LetniDelavec a = new LetniDelavec();
            //a.DelID = "987";
            //a.Ime = "Marija Novak";
            //a.LetnaPlača = 12000;
            //a.Izpis();
            //DelavecAbs b = new LetniDelavec();
        }
    }
}
