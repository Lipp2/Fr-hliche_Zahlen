using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fröhliche_Zahlen;

namespace Test_Fröhliche_Zahlen
{
    [TestFixture]
    public class Test
    {
        [Test, Category("Akzeptanztest")]
        public void Eingabe_test()
        {
            var ergebnis = Start_FZ.Eingabe_FroheZahl(19);
            Assert.AreEqual(19, ergebnis);
        }

        [Test, Category("Programmtest")]
        public void Programmtest()
        {
            var ergebnis = Start_FZ.Berechne_FroheZahl(24);
            Assert.AreEqual(true, ergebnis); // ture = traurig, false = fröhlich
        }

        [Test, Category("nocheintest")]
        public void Ausgabetest()
        {
            var ergebnis = Start_FZ.Ausgabe_FroheZahl(24);
            Assert.AreEqual("Eine traurige Zahl :(", ergebnis); // "Eine sehr fröhliche Zahl :)" | "Eine traurige Zahl :("
        }
    }
}
