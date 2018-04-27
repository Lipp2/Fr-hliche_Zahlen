using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_to_Rom
{
    public class Start_Dec_to_Rom
    {
        internal static string ToRoman(int zahl)
        {
            string[] tausender = { "", "M", "MM", "MMM" };
            string[] hunderter = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] zehner = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] einer = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            var roman = "";
            roman += tausender[(zahl / 1000) % 10];
            roman += hunderter[(zahl / 100) % 10];
            roman += zehner[(zahl / 10) % 10];
            roman += einer[zahl % 10];

            return roman;
        }
    }
}
