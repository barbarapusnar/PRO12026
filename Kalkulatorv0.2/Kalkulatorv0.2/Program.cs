
namespace Kalkulatorv0._2
{
    using System;
    using System.Windows.Forms;
    internal class Program
    {
        static void Main(string[] args)
        {
            string šeKakšenŠtudent = "";
            do
            {
                Console.WriteLine("Vnesi oddelek študenta 1-ang,2-mat,3-nar");
                int oddelek = int.Parse(Console.ReadLine());
                Odseki o = (Odseki)oddelek;
                int delni1 = 0;
                int delni2 = 0;
                int seminar = 0;
                int ustna = 0;
                double končna = 0;
                string črka = "";
                //glede na oddelek študenta
                switch (o)
                {
                    case Odseki.Angleščina:
                        //napiši kodo
                        break;
                    case Odseki.Matematika: //študent mat
                        Console.WriteLine("Vnesi oceno delnega izpita 1");
                        delni1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Vnesi oceno delnega izpita 2");
                        delni2 = int.Parse(Console.ReadLine());
                        končna = 0.5 * delni1 + 0.5 * delni2;
                        if (končna >= 90)
                            črka = "A";
                        else if (končna >= 83)
                            črka = "B";
                        else if (končna >= 76)
                            črka = "C";
                        else if (končna >= 65)
                            črka = "D";
                        else
                            črka = "F";
                        //Console.WriteLine("Končna ocena = " + končna);
                        //Console.WriteLine("Končna črka  = " + črka);
                        MessageBox.Show("Končna ocena " + končna +
                            Environment.NewLine + "Končna črka  = " + črka,"VSŠ",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                        break;
                    case Odseki.Naravoslovje://študent naravoslovja
                        break;
                }//konec switch
                Console.WriteLine("Še kakšen študent? DA/NE");
                šeKakšenŠtudent = Console.ReadLine().ToUpper();
            } while (šeKakšenŠtudent == "DA");
     }
    }
}
