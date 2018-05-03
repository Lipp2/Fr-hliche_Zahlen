using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_plebmultiplicator
{
    public class pleb_Start
    {
        internal static int[] Vergleichen_zahl1_zahl2(int x, int y)
        {
            int[] zahl1 = Zahl1_Dividieren(x);
            int[] zahl2 = Zahl2_Multiplizieren(x, y);

            for (int i = 0; i < zahl1.Length; i++)
            {
                if (zahl1[i] % 2 == 0)
                {
                    zahl2[i] = 0;
                }
            }
            return zahl2;
        }

        internal static int[] Zahl1_Dividieren(int x)
        {
            List<int> zwischenergebnis = new List<int>();
            zwischenergebnis.Add(x);
            while (x != 1)
            {
                x = (x / 2);
                zwischenergebnis.Add(x);
            }
            int[] ergebnis = zwischenergebnis.ToArray();
            return ergebnis;
        }

        internal static int[] Zahl2_Multiplizieren(int x, int y)
        {
            int[] zahl1 = Zahl1_Dividieren(x);
            List<int> zwischenergebnis = new List<int>();
            for (int i = 0; i != zahl1.Length; i++)
            {
                zwischenergebnis.Add(y);
                y = y * 2;
            }
            int[] ergebnis = zwischenergebnis.ToArray();
            return ergebnis;
        }

        internal static int Ergebnis_addieren(int x, int y)
        {
            int ergebnis = 0;
            int[] zahlen = Vergleichen_zahl1_zahl2(x, y);

            for (int i = 0; i != zahlen.Length; i++)
            {
                ergebnis += zahlen[i];
            }

            return ergebnis;
        }
    }



}
