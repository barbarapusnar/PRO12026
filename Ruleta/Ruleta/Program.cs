namespace Ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.uporabnik naj vnese začetni denarni vložek, shrani ga v spremenljivko stanje
            Console.WriteLine("Koliko denarja si prinesel za zapraviti?");
            int stanje = int.Parse(Console.ReadLine());
            //2.uporabnik naj vnese začetno višino stave, shrani ga v spremenljivko stava
            Console.WriteLine("Koliko je začetna stava?");
            int stava = int.Parse(Console.ReadLine());
            //3.V spremenljivkah stanje in stava bom imela trenutno stanje in trenutno stavo, zapomniti pa si
            //moram tudi znesek s katerim sem začela igrati in začetno stavo  deklarirajte spremenljivki
            //začStanje(ki je na začetku enaka stanje) in začStava(= stava)
            int začStanje = stanje;
            int začStava = stava;
            //4.Ker bi radi imeli tudi največje oziroma najmanjše stanje, ki smo ga med meti imeli, si na tem
            //mestu deklarirajmo še spremenljivki min in max.
            int min = 100000;
            int max = -100000;
            Random r = new Random();
            //5. 10 krat ponovimo
            for(int k=1;k<=1000;k++)
            {
                //a.vrzi kroglico(naključno število med 0 in 36)
                int število = r.Next(37);
                //b.če je število sodo in različno od 0
                if (število % 2 == 0 && število != 0)
                {
                    //i.stavo smo dobili  povečaj stanje za stavo, stava = začStava, barva = rdeča
                    stanje += stava;
                    stava = začStava;
                    Console.WriteLine(k + ". " + " rdeča - zmaga " + stanje);
                }
                else
                {
                    //c.sicer
                    //i.stavo smo izgubilizmanjšaj stanje za stavo, stava = 2 * stava, barva = črna
                    stanje -= stava;
                    stava = 2*stava;
                    Console.WriteLine(k + ". " + " črna - izguba " + stanje);
                }
                if (stanje < min)
                    min = stanje;
                if (stanje > max)
                    max = stanje;
                //e.preveri ali je stanje manjše od min
                //f.preveri ali je stanje večje od max
            }
            Console.WriteLine("Število metov 10");
            Console.WriteLine("Na začetku "+začStanje);
            Console.WriteLine("Na koncu "+stanje);
            Console.WriteLine("Min      "+min);
            Console.WriteLine("Max      "+max);
            Console.WriteLine("Dobiček  "+(stanje-začStanje));
            //6.Na koncu izpiši:
            //a.število metov
            //b.začetno stanje
            //c.končno stanje
            //d.najvišje stanje
            //e.najnižje stanje
            //f.dobiček ali izgubo(končno stanje – začetno stanje)
        }
    }
}
