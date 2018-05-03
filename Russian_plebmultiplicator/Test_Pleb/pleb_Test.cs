using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Russian_plebmultiplicator;

namespace Test_Pleb
{
    [TestFixture]
    public class pleb_Test
    {
        [Test, Category("Zahl1")]
        public void Zahlx_länge()
        {
            var ergebnis = pleb_Start.Zahl1_Dividieren(47);
            Assert.AreEqual(6, ergebnis.Length);
        }

        [Test, Category("Zahl1")]
        public void Zahlx_array()
        {
            var ergebnis = pleb_Start.Zahl1_Dividieren(47);
            Assert.AreEqual(1, ergebnis[5]);
        }

        [Test, Category("Zahl2")]
        public void Zahly_länge()
        {
            var ergebnis = pleb_Start.Zahl2_Multiplizieren(47, 42);
            Assert.AreEqual(6, ergebnis.Length);
        }

        [Test, Category("Zahl2")]
        public void Zahly_array()
        {
            var ergebnis = pleb_Start.Zahl2_Multiplizieren(47, 42);
            Assert.AreEqual(84, ergebnis[1]);
        }

        [Test, Category("Vergleichen")]
        public void Vergleichen()
        {
            var ergebnis = pleb_Start.Vergleichen(47, 42);
            Assert.AreEqual(0, ergebnis[4]);
        }
    }
}
