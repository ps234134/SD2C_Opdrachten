using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeltevreeCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeltevreeCore6.Models.Tests
{
    [TestClass()]
    public class VerblijfTests
    {

        [TestMethod()]
        public void VerlengenTest()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier hond = new Dier(new DateTime(2000, 11, 01), "dierRas");

            DateTime van = new DateTime(2022, 12, 01);
            DateTime tot = new DateTime(2022, 12, 02);

            //Act
            Verblijf verblijf = new Verblijf(pieter, hond, van, tot);

            verblijf.Verlengen(new DateTime (2022, 12, 02));

            Assert.AreEqual(5, verblijf.Administratiekosten, "Test is fout");
        }

        [TestMethod()]
        public void AnnulerenTest()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier hond = new Dier(new DateTime(2000, 11, 01), "dierRas");

            DateTime van = new DateTime(2022, 12, 01);
            DateTime tot = new DateTime(2022, 12, 02);

            //Act
            Verblijf verblijf = new Verblijf(pieter, hond, van, tot);

            verblijf.Annuleren();

            Assert.AreEqual(5, verblijf.Administratiekosten, "Test is fout");
        }

        [TestMethod()]
        public void BehandelenTest()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier hond = new Dier(new DateTime(2000, 11, 01), "dierRas");

            DateTime van = new DateTime(2022, 12, 01);
            DateTime tot = new DateTime(2022, 12, 02);

            //Act
            Verblijf verblijf = new Verblijf(pieter, hond, van, tot);

            verblijf.Behandelen(SoortBehandeling.Parasietbehandeling);



            Assert.AreEqual(18, verblijf.TotaalPrijs(), "Test is fout");
        }

        [TestMethod()]
        public void BehandelenTest2()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier hond = new Dier(new DateTime(2000, 11, 01), "dierRas");

            DateTime van = new DateTime(2022, 12, 01);
            DateTime tot = new DateTime(2022, 12, 02);

            //Act
            Verblijf verblijf = new Verblijf(pieter, hond, van, tot);

            verblijf.Behandelen(SoortBehandeling.Inenten);



            Assert.AreEqual(38, verblijf.TotaalPrijs(), "Test is fout");
        }

        [TestMethod()]
        public void BehandelenTest3()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier hond = new Dier(new DateTime(2000, 11, 01), "dierRas");

            DateTime van = new DateTime(2022, 12, 01);
            DateTime tot = new DateTime(2022, 12, 02);

            //Act
            Verblijf verblijf = new Verblijf(pieter, hond, van, tot);

            verblijf.Behandelen(SoortBehandeling.Chippen);



            Assert.AreEqual(28, verblijf.TotaalPrijs(), "Test is fout");
        }

        [TestMethod()]
        public void BehandelenTest4()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier hond = new Dier(new DateTime(2000, 11, 01), "dierRas");

            DateTime van = new DateTime(2022, 12, 01);
            DateTime tot = new DateTime(2022, 12, 02);

            //Act
            Verblijf verblijf = new Verblijf(pieter, hond, van, tot);

            verblijf.Behandelen(SoortBehandeling.UitlaatService);



            Assert.AreEqual(17, verblijf.TotaalPrijs(), "Test is fout");
        }

        [TestMethod()]
        public void TotaalPrijsTestHond()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier hond = new Dier(new DateTime(2000, 11, 01), "dierRas");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 12 , 01);
            DateTime tot = new DateTime(2022, 12, 02);
            //Act
            Verblijf verblijf = new Verblijf(pieter, hond, van, tot);


            Assert.AreEqual(13, verblijf.TotaalPrijs(), "Test is fout");
        }

        [TestMethod()]
        public void TotaalPrijsTestKat()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier kat = new Dier(new DateTime(2000, 11, 01), "dierRas");
            kat.Soort = Diersoort.Kat;

            DateTime van = new DateTime(2022, 12, 01);
            DateTime tot = new DateTime(2022, 12, 02);
            //Act
            Verblijf verblijf = new Verblijf(pieter, kat, van, tot);


            Assert.AreEqual(7, verblijf.TotaalPrijs(), "Test is fout");
        }

        [TestMethod()]
        public void TotaalPrijsTestKonijn()
        {
            //Arrange
            Eigenaar pieter = new Eigenaar("Pieter");

            Dier konijen = new Dier(new DateTime(2000, 11, 01), "dierRas");
            konijen.Soort = Diersoort.Konijen;

            DateTime van = new DateTime(2022, 12, 01);
            DateTime tot = new DateTime(2022, 12, 02);
            //Act
            Verblijf verblijf = new Verblijf(pieter, konijen, van, tot);


            Assert.AreEqual(5, verblijf.TotaalPrijs(), "Test is fout");
        }
    }
}