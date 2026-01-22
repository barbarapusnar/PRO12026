namespace KalkulatorOcenv0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delni1 = 70;
            int delni2 = 80;
            int seminar = 90;
            int ustna = 100;
            const double D1PROCENT = 0.25;
            const double D2PROCENT = 0.25;
            const double SPROCENT = 0.3;
            const double UPROCENT = 0.2;
            double končnaOcena =
                D1PROCENT * delni1 +
                D2PROCENT * delni2 +
                SPROCENT * seminar +
                UPROCENT * ustna;
            Console.WriteLine("Končna ocena je "+končnaOcena+".");
            Console.WriteLine("Delni izpit 1 je {0},delni izpit 2 ={1}", delni1,delni2);
        }
    }
}
