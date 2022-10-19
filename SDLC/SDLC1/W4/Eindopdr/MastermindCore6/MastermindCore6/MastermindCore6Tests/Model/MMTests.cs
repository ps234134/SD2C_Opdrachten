using Microsoft.VisualStudio.TestTools.UnitTesting;
using MastermindCore6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindCore6.Model.Tests
{
    [TestClass()]
    public class MMTests
    {
        [TestMethod()]
        public void TestMethodPosities()
        {
            MM mm = new MM();
            mm.TeRaden = "1234";    
            mm.Poging = "0253";
            int u = mm.PositiesOK();
            Assert.AreEqual(1, u, "PositiesOK fout");
        }




        [TestMethod()]
        public void TestMethodAantal()
        {
            MM mm = new MM();
            mm.TeRaden = "1234";
            mm.Poging = "0253";
            int u = mm.AantalOK();
            Assert.AreEqual(2, u, "Aantalok fout");
        }

        [TestMethod()]
        public void TestMethodAantal2()
        {
            MM mm = new MM();
            mm.TeRaden = "1234";
            mm.Poging = "2253";
            int u = mm.AantalOK();
            Assert.AreEqual(2, u, "Aantalok versie 3 fout");

        }

        [TestMethod()]
        public void TestMethodAantal3()
        {
            MM mm = new MM();
            mm.TeRaden = "1234";
            mm.Poging = "2253";
            int u = mm.AantalOK();
            Assert.AreEqual(2, u, "Aantalok versie 3 fout");

        }

    }
     
}