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
        public void Blabla()
        {
            var ergebnis = Start_Dec_to_Rom.ToRoman(564);
            Assert.AreEqual("DLXIV", ergebnis);
        }
    }
}
