using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Dec_to_Rom;

namespace Test_Dec_to_Rom
{
    [TestFixture]
    public class Test
    {
        [Test, Category("Akzeptanztest")]
        public void Zahlen_Test()
        {
            var ergebnis = Start_Dec_to_Rom.ToRoman(564);
            Assert.AreEqual("DLXIV", ergebnis);
            var ergebnis2 = Start_Dec_to_Rom.ToRoman(100);
            Assert.AreEqual("C", ergebnis2);
            var ergebnis3 = Start_Dec_to_Rom.ToRoman(354);
            Assert.AreEqual("CCCLIV", ergebnis3);
            var ergebnis4 = Start_Dec_to_Rom.ToRoman(42);
            Assert.AreEqual("XLII", ergebnis4);
        }
    }
}
