using Microsoft.VisualStudio.TestTools.UnitTesting;
using Balaton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaton.Tests
{
    [TestClass()]
    public class BalatonCLITests
    {
        [TestMethod()]
        public void AdoTest1()
        {
            int elvart = 18000;
            int szamitott = BalatonCLI.Ado("C", 180);
            Assert.AreEqual(elvart, szamitott);
        }
        [TestMethod()]
        public void AdoTest2()
        {
            int elvart = 96000;
            int szamitott = BalatonCLI.Ado("A", 120);
            Assert.AreEqual(elvart, szamitott);
        }
        [TestMethod()]
        public void AdoTest3()
        {
            int elvart = 33600;
            int szamitott = BalatonCLI.Ado("B", 56);
            Assert.AreEqual(elvart, szamitott);
        }
        [TestMethod()]
        public void AdoTest4()
        {
            int elvart = 0;
            int szamitott = BalatonCLI.Ado("C", 90);
            Assert.AreEqual(elvart, szamitott);
        }
    }
}