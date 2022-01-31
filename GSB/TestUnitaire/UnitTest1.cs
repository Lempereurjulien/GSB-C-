using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GSB;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetMoisPrecedentOK()
        {
            
            var a = GestionsDates.GetMoisPrecedent();
            int moisPreced = DateTime.Now.Month-1;   
            if(moisPreced == 0)
            {
                moisPreced = 12;
            }

            
            Assert.AreEqual(GestionsDates.GetMoisPrecedent(), moisPreced.ToString("D2"));
        }

        [TestMethod]
        public void TestGetMoisPrecedentKO()
        {
            int moisPreced = DateTime.Now.Month + 1;
            if (moisPreced == 13)
            {
                moisPreced = 1;
            }
            Assert.AreNotEqual(GSB.GestionsDates.GetMoisPrecedent(), moisPreced);
        }
        [TestMethod]
        public void TestGetMoisSuivantOK()
        {
            int moisProchain = 0;
            var moisActuelle = DateTime.Now.Month;
            if (moisActuelle == 12)
            {
                moisProchain = 1;
            }
            else {
                moisProchain = moisActuelle + 1;
            };
            Assert.AreEqual(GestionsDates.GetMoisSuivant(), moisProchain.ToString("D2"));
        }
        [TestMethod]
        public void TestGetMoisSuivantKO()
        {
            int moisProchain = 0;
            var moisActuelle = DateTime.Now.Month;
            if (moisActuelle == 12)
            {
                moisProchain = 1;
            }
            else
            {
                moisProchain = moisActuelle + 2;
            };
            Assert.AreNotEqual(GestionsDates.GetMoisSuivant(), moisProchain.ToString("D2"));
        }
        [TestMethod]
        public void TesteEntreOK()          
        {
            string test;
            int date1 = DateTime.Now.Day;
            int date2 = DateTime.Now.Day +2 ;
            if (DateTime.Now.Day > date1 & DateTime.Now.Day < date2)
            {
                 test = "La date du jour est entre.";
            }
            else {
                 test = "La date du jour est à l'extérieur.";
                    }
            Assert.AreEqual(GestionsDates.Entre(date1, date2), test);
        }
        [TestMethod]
        public void TestEntreKO()
        {
            string test;
            int date1=DateTime.Now.Day-2;
            int date2 = DateTime.Now.Day - 1;
            if (DateTime.Now.Day > date1 & DateTime.Now.Day < date2)
            {
                test = "La date du jour est extérieur.";
            }
            else
            {
                test = "Date extérieur";
            }
          
            Assert.AreNotEqual(GestionsDates.Entre(date1, date2), test);
        }
        [TestMethod]
        public void TestEntre2OK()
        {
            string test;
            int date1 = DateTime.Now.Day-1;
            int date2 = DateTime.Now.Day+1;
            int date3 = DateTime.Now.Day;
            if(date3 > date1 & date3 < date2)
            {
                test = "La date du jour est entre.";
            }
            else
            {
                test = "La date du jour est extérieur";
            }
            Assert.AreEqual(GestionsDates.Entre(date1 , date2, date3), test);
        }
        [TestMethod]
        public void TestEntre2KO()
        {
            string test;
            int date1 = DateTime.Now.Day + 1;
            int date2 = DateTime.Now.Day + 2;
            int date3 = DateTime.Now.Day;
            if (date3 > date1 & date3 < date2)
            {
                test = "La date du jour est entre.";
            }
            else
            {
                test = "La date du jour est extérieur";
            }
            Assert.AreNotEqual(GestionsDates.Entre(date1, date2, date3), test);
        }
    }
}
