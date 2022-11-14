using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeltevreeCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace WeltevreeCore6.Models.Tests
{
    [TestClass()]
    public class VerblijfTests
    {
       
        [TestMethod()]
        public void VerblijfTest()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier hond = new Dier(time, "ras");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, hond, van, tot);
            Assert.AreEqual(van, verblijf.Van, "(Property van) verblijftest is fout");
            Assert.AreEqual(tot, verblijf.Tot, "(Property tot) verblijftest is fout");





        }
        [TestMethod()]
        public void VerlengenTest()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier hond = new Dier(time, "ras");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, hond, van, tot);

            verblijf.Verlengen(new DateTime(2022, 3, 1));

            Assert.AreEqual(5, verblijf.Administratiekosten, "Verlengtest is fout");

        }

        [TestMethod()]
        public void AnnulerenTest()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier hond = new Dier(time, "ras");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, hond, van, tot);

            verblijf.Annuleren();

            Assert.AreEqual(5, verblijf.Administratiekosten, "Annuleertest is fout");
        }

        [TestMethod()]
        public void BehandelenTest()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier hond = new Dier(time, "ras");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, hond, van, tot);

            verblijf.Behandelen(SoortBehandeling.Parasietbehandeling);

            Assert.AreEqual(70, verblijf.TotaalPrijs(), "Behandeltest is fout");
        }

        [TestMethod()]

        public void BehandelenTest2()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier hond = new Dier(time, "ras");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, hond, van, tot);

            verblijf.Behandelen(SoortBehandeling.Inenten);

            Assert.AreEqual(90, verblijf.TotaalPrijs(), "Behandeltest is fout");
        }

        [TestMethod()]

        public void BehandelenTest3()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier hond = new Dier(time, "ras");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, hond, van, tot);

            verblijf.Behandelen(SoortBehandeling.Chippen);

            Assert.AreEqual(80, verblijf.TotaalPrijs(), "Behandeltest is fout");
        }

        [TestMethod()]
        public void BehandelenTest4()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier hond = new Dier(time, "ras");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, hond, van, tot);

            verblijf.Behandelen(SoortBehandeling.UitlaatService);

            Assert.AreEqual(69, verblijf.TotaalPrijs(), "Behandeltest is fout");
        }

        [TestMethod()]
        public void PrijsTestHond()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier hond = new Dier(time, "ras");
            hond.Soort = Diersoort.Hond;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, hond, van, tot);

            Assert.AreEqual(65, verblijf.TotaalPrijs(), "Prijstest is fout");
        }

        [TestMethod()]
        public void PrijsTestKat()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier kat = new Dier(time, "ras");
            kat.Soort = Diersoort.Kat;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, kat, van, tot);
            Assert.AreEqual(35, verblijf.TotaalPrijs(), "Prijstest is fout");
        }

        [TestMethod()]
        public void PrijsTestKonijn()
        {
            Eigenaar Eigenaar = new Eigenaar("henk");

            DateTime time = new DateTime(2022, 1, 21);

            Dier konijn = new Dier(time, "ras");
            konijn.Soort = Diersoort.Konijn;

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Verblijf verblijf = new Verblijf(Eigenaar, konijn, van, tot);
            Assert.AreEqual(25, verblijf.TotaalPrijs(), "Prijstest is fout");
        }

    }
}