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

            Dier Hond = new Dier(time, "ras");

            DateTime van = new DateTime(2022, 2, 23);
            DateTime tot = new DateTime(2022, 2, 28);


            Eigenaar Eigenaar_verwacht = new Eigenaar("henk");

            DateTime time_verwacht = new DateTime(2022, 1, 21);

            Dier Hond_verwacht = new Dier(time_verwacht, "ras");

            DateTime van_verwacht = new DateTime(2022, 2, 23);
            DateTime tot_verwacht = new DateTime(2022, 2, 28);




            Verblijf verblijf = new Verblijf(Eigenaar, Hond, van, tot);
            Verblijf verblijf_verwacht = new Verblijf(Eigenaar_verwacht, Hond_verwacht, van_verwacht, tot_verwacht);
            Assert.AreEqual(verblijf, verblijf_verwacht );

           

        }
        [TestMethod()]
        public void VerlengenTest()
        {            
                                                        
        }

        [TestMethod()]
        public void AnnulerenTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BehandelenTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TotaalPrijsTest()
        {
            Assert.Fail();
        }
    }
}