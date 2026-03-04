using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogomet
{
    internal class Liga
    {
        Ekipa[] vse = new Ekipa[10];
        int[,] pari = new int[10, 10]; //če je pari[3,4]=8, pomeni
        //da se ekipa vse[3] in vse[4] srečata v 8. kolu turnirja
        int x = 0;
        int y = 1;
        int[] gor = { 2, 3, 4, 5 };
        int[] dol = { 9, 8, 7, 6 };
        public Liga()
        {
            vse[0] = new Ekipa("Slovenija");
            vse[1] = new Ekipa("Škotska  ");
            vse[2] = new Ekipa("Italija  ");
            vse[3] = new Ekipa("Irska    ");
            vse[4] = new Ekipa("Islandija");
            vse[5] = new Ekipa("Anglija  ");
            vse[6] = new Ekipa("Španija  ");
            vse[7] = new Ekipa("Švedska  ");
            vse[8] = new Ekipa("Finska   ");
            vse[9] = new Ekipa("Nemčija  ");
           
        }
    }
}
