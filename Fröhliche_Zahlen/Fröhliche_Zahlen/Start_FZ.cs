using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fröhliche_Zahlen
{
    public class Start_FZ
    {
        internal static List<int> Teilen(string value)
        {
            string zwischenspeicher;
            List<int> zahlen = new List<int>();
            for (int i = 0; i < value.Length; i++)
            {
                int startIndex = i;
                int length = 1;
                zwischenspeicher = value.Substring(startIndex, length);
                zahlen.Add(Convert.ToInt32(zwischenspeicher));
            }
            return zahlen;
        }

        internal static bool FroheZahl(int nummer)
        {
            int Zahl;
            int ergebnis = 0;
            bool traurig = false;
            while (nummer != 1 && traurig == false)
            {
                while (nummer != 0 && traurig == false)
                {
                    Zahl = nummer % 10;
                    ergebnis += Zahl * Zahl;
                    nummer = nummer / 10;
                }
                nummer = ergebnis;
                if (nummer == 4)
                {
                    return true;
                }
                ergebnis = 0;
            }
            return false;
        }

        //internal static string Berechnen(string value)
        //{
        //    List<int> zahlen = Teilen(value);
        //    int zahl1 = zahlen[0];
        //    int zahl2 = 0;
        //    if (zahlen.Count >= 2)
        //    {
        //        zahl2 = zahlen[1];
        //    }
        //    int zahl3 = 0;
        //    if (zahlen.Count == 3)
        //    {
        //        zahl3 = zahlen[2];
        //    }
        //    string ende = "";
        //    int ergebnis = zahl1 * zahl1 + zahl2 * zahl2 + zahl3 * zahl3;
        //    do
        //    {
        //        if (ergebnis == 4)
        //        {
        //            ende = "traurige Zahl :(";
        //        }
        //        else if (ergebnis == 1)
        //        {
        //            ende = "fröhliche Zahl :)";
        //        }
        //        else
        //        {
        //            List<int> zahlen2 = Teilen(Convert.ToString(ergebnis));
        //            int nzahl1 = zahlen2[0];
        //            int nzahl2 = 0;
        //            if (zahlen2.Count >= 2)
        //            {
        //                nzahl2 = zahlen2[1];
        //            }
        //            int nzahl3 = 0;
        //            if (zahlen2.Count == 3)
        //            {
        //                nzahl3 = zahlen2[2];
        //            }
        //            ergebnis = zahl1 * zahl1 + zahl2 * zahl2 + nzahl3 * nzahl3;
        //            ende = "traurige Zahl :(";
        //        }
        //    } while (ende == "");
        //    return ende;
        //}
    }
}
