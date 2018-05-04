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
            Assert.AreEqual(new[] {47, 23, 11, 5, 2, 1}, ergebnis);
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
            Assert.AreEqual(new[] {42, 84, 168, 336, 672, 1344 }, ergebnis);
        }

        [Test, Category("Vergleichen")]
        public void Vergleichen()
        {
            var ergebnis = pleb_Start.Vergleichen_zahl1_zahl2(47, 42);
            Assert.AreEqual(new[] { 42, 84, 168, 336, 0, 1344 }, ergebnis);
        }

        [Test, Category("Ergebnis")]
        public void Ergebnis()
        {
            var ergebnis = pleb_Start.Ergebnis_addieren(47, 42);
            Assert.AreEqual(1974, ergebnis);
        }
    }
}
