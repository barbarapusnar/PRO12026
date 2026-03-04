namespace Tabele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[10]; //a[0]=0,.....a[9]=0
            int[] a = {5,3,7,8,11 };
            int vsota = 0;
            for (int k = 0; k < a.Length; k++)
            {
                a[k] = k + 1;
                vsota += a[k];
                Console.WriteLine(a[k]);
            }
            Console.WriteLine(vsota);
            int[,] b = {
               { 3,4,5},
               {7,8,9 },
               {1,2,3 }
                        };
            Random r = new Random();
            for (int vrstica = 0; vrstica < b.GetLength(0); vrstica++)
            {
                for (int stolpec = 0; stolpec < b.GetLength(1); stolpec++)
                {
                    b[vrstica, stolpec] = r.Next(101);
                    Console.Write(b[vrstica,stolpec]+"\t");
                }
                Console.WriteLine();
            }
            string[] študenti = { "gvsdfjg", "hfwseflh", "dfkge" };
            double[] x = new double[5000];
            Napis[] vsiJeziki = new Napis[5];//vsiJeziki[0]=null,...
            for (int k = 0; k < 5; k++)
            {
                //vsiJeziki[k] = new Napis();
                vsiJeziki[k].jezik = "C#";
                vsiJeziki[k].Izpiši();
            }

        }
    }
}
