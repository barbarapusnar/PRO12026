using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcenV1._0
{
    internal class StudentMat : StudentAbs
    {
        public override string Izpis()
        {
            string r = "*******ŠTUDENT MATEMATIKE****" + Environment.NewLine;
            r += "Delni 1    " + delni1 + Environment.NewLine;
            r += "Delni 2    " + delni2 + Environment.NewLine;
            r += "Ocena točk " + KončnaOcena() + Environment.NewLine;
            r += "Črka       " + KončnaČrka() + Environment.NewLine;
            return r;
        }

        public override double KončnaOcena()
        {
            return delni1 * 0.5 + delni2 * 0.5;
        }

        public override string KončnaČrka()
        {//90,83,76,65
            if (KončnaOcena() >= 90)
                return "A";
            if (KončnaOcena() >= 83)
                return "B";
            if (KončnaOcena() >= 76)
                return "C";
            if (KončnaOcena() >= 65)
                return "D";
            return "F";
        }
    }
}
