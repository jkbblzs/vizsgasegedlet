using Microsoft.VisualStudio.TestTools.UnitTesting;
using helsinki1952;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952.Tests
{
    [TestClass()]
    public class helsinki1952Tests
    {
        [TestMethod()]
        public void HelyezesTest1()
        {
            int elvartertek = 7;
            int szamitott = helsinki1952.Helyezes(1);
            Assert.AreEqual(elvartertek,szamitott);
        }

        [TestMethod()]
        public void HelyezesTest2()
        {
            int elvartertek = 5;
            int szamitott = helsinki1952.Helyezes(2);
            Assert.AreEqual(elvartertek, szamitott);
        }

        [TestMethod()]
        public void HelyezesTest3()
        {
            int elvartertek = 4;
            int szamitott = helsinki1952.Helyezes(3);
            Assert.AreEqual(elvartertek, szamitott);
        }

        [TestMethod()]
        public void HelyezesTest4()
        {
            int elvartertek = 3;
            int szamitott = helsinki1952.Helyezes(4);
            Assert.AreEqual(elvartertek, szamitott);
        }

        [TestMethod()]
        public void HelyezesTest5()
        {
            int elvartertek = 2;
            int szamitott = helsinki1952.Helyezes(5);
            Assert.AreEqual(elvartertek, szamitott);
        }

        [TestMethod()]
        public void HelyezesTest6()
        {
            int elvartertek = 1;
            int szamitott = helsinki1952.Helyezes(6);
            Assert.AreEqual(elvartertek, szamitott);
        }

        [TestMethod()]
        public void HelyezesTest7()
        {
            int elvartertek = 0;
            int szamitott = helsinki1952.Helyezes(7);
            Assert.AreEqual(elvartertek, szamitott);
        }
    }
}