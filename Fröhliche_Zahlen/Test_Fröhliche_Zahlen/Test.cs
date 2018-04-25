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
        public void Teilen_test()
        {
            var ergebnis = Start_FZ.Teilen("19");
            Assert.AreEqual(9, ergebnis[1]);
        }

        [Test, Category("Programmtest")]
        public void Programmtest()
        {
            var ergebnis = Start_FZ.Berechnen("4");
            Assert.AreEqual("fröhliche Zahl :)", ergebnis);
        }
    }
}
