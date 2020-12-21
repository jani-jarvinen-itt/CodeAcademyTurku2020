using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetWebDemo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetWebDemo.Logic.Tests
{
    [TestClass()]
    public class LaskentaTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            int a = 100;
            int b = 200;

            Laskenta laskenta = new Laskenta();
            int summa = laskenta.Summa(a, b);

            int odotus = a + b;
            Assert.AreEqual(odotus, summa);
        }
    }
}