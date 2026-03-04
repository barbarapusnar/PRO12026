namespace SprehodPoHiši
{
    internal class Program
    {
        static SobaZVrati dnevnaSoba;
        static Soba jedilnica;
        static SobaZVrati kuhinja;
        static ZunanjiZVrati zadnjeDvorišče;
        static ZunanjiZVrati sprednjeDvorišče;
        static Zunanji vrt;
        static Lokacija trenutnaLokacija; //shrani kje trenutno si
        static void Main(string[] args)
        {
            UstvariHišo();
            PremakniSe(dnevnaSoba);
            string nova = "";
            while (nova != "K")
            {
                Console.WriteLine("Kam naj grem? K za Konec");
                nova = Console.ReadLine();
                Lokacija novaLokacija = null;
                if (nova == "K")
                {
                    Console.WriteLine("Lep sprehod!");
                    break;
                }
                if (nova == "I")
                {
                    if (trenutnaLokacija is IZunanjaVrata)
                        novaLokacija = ((IZunanjaVrata)trenutnaLokacija).lokacijaVrat();
                }
                else
                {
                    int št = int.Parse(nova);
                    novaLokacija = trenutnaLokacija.izhodi[št];                   
                }
                PremakniSe(novaLokacija);
            }
        }
        public static void UstvariHišo()
        {
            dnevnaSoba = new SobaZVrati("Dnevna soba", "starinski tepih",
            "hrastova vrata");
            jedilnica = new Soba("Jedilnica", "kristalni luster");
            kuhinja = new SobaZVrati("Kuhinja", "nerjaveči pripomočki", "navadna vrata");
           
            sprednjeDvorišče = new ZunanjiZVrati("Sprednje dvorišče", false, "hrastova vrata");
           
            zadnjeDvorišče = new ZunanjiZVrati("Zadnje dvorišče", true, "navadna vrata");
           
            vrt = new Zunanji("Vrt", false);
            jedilnica.izhodi = new Lokacija[2];
            jedilnica.izhodi[0] = dnevnaSoba;
            jedilnica.izhodi[1] = kuhinja;
            dnevnaSoba.izhodi = new Lokacija[1];
            dnevnaSoba.izhodi[0] = jedilnica;
            kuhinja.izhodi = new Lokacija[1];
            kuhinja.izhodi[0] = jedilnica;
            sprednjeDvorišče.izhodi = new Lokacija[2];
            sprednjeDvorišče.izhodi[0] = zadnjeDvorišče;
            sprednjeDvorišče.izhodi[1] = vrt;
            zadnjeDvorišče.izhodi = new Lokacija[2];
            zadnjeDvorišče.izhodi[0] = sprednjeDvorišče;
            zadnjeDvorišče.izhodi[1] = vrt;
            vrt.izhodi = new Lokacija[2];
            vrt.izhodi[0] = zadnjeDvorišče;
            vrt.izhodi[1] = sprednjeDvorišče;
            dnevnaSoba.lok = sprednjeDvorišče;
            sprednjeDvorišče.lok = dnevnaSoba;
            kuhinja.lok = zadnjeDvorišče;
            zadnjeDvorišče.lok = kuhinja;
        }
        public static void PremakniSe(Lokacija nova)
        {
            trenutnaLokacija = nova;
            string a = trenutnaLokacija.Opis();
            if (trenutnaLokacija is IZunanjaVrata) //ali je trenutna lokacija tipa IZunanjaVrata
            {
                a += "(I) - Pojdi skozi vrata";
            }
            Console.WriteLine(a);
        }
    }
    }
