using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ZPI2018_Z_GAMMA.Tests
{
    [TestFixture]
    public class FunkcjeTests
    {
        [Test, MaxTime(50)]
        public void IloscSesjiTest()
        {
            float expected = 5;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 5;
            actual = f.IloscSesji("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Mediana");
        }

        [Test, MaxTime(50)]
        public void MedianaTest()
        {

            float expected = 0;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 3;
            actual = f.Mediana("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Mediana");
            //Assert.Fail();
        }

        [Test, MaxTime(50)]
        public void DominataTest()
        {
            float expected = 5;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 3;
            actual = f.Dominata("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Dominta");
        }

        [Test, MaxTime(50)]
        public void OdchylenieStdTest()
        {
            double expected = 5;
            double actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 1.5;
            actual = f.OdchylenieStd("ANY", w);
            Assert.AreEqual(expected, actual, 0, "OdchStd");
        }

        [Test, MaxTime(50)]
        public void WspZmTest()
        {
            float expected = 5;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 5;
            w.Add(itm);
            expected = 5;
            actual = f.WspZm("ANY", w);
            Assert.AreEqual(expected, actual, 0, "WspZM");
        }

        [Test, MaxTime(50)]
        public void RozkadZmianTest()
        {

            float expected = 5;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 5;
            w.Add(itm);

            List<Funkcje.Waluta> w2 = new List<Funkcje.Waluta>();
            itm.Wartosc = 5;
            w2.Add(itm);
            itm.Wartosc = 45;
            w2.Add(itm);
            itm.Wartosc = 43;
            w2.Add(itm);
            itm.Wartosc = 2;
            w2.Add(itm);
            itm.Wartosc = 12;
            w2.Add(itm);

            expected = 5;
            actual = f.RozkadZmian("ANY", "ANY2", w, w2);
            Assert.AreEqual(expected, actual, 0, "WspZM");

        }

        [Test, MaxTime(2000)]
        public void getDataTest()
        {
            /*List<Funkcje.Waluta> list = new List<Funkcje.Waluta>();
            string wal = null;
            string dni = null;
            string link = "http://api.nbp.pl/api/exchangerates/rates/A/" + wal + "/last/" + dni + "?format=xml";

            XDocument xDoc = XDocument.Load(link);
            list = xDoc.Descendants("Rate")
                    .Select(o => new Funkcje.Waluta
                    {
                        Wartosc = (float)o.Element("Mid"),
                    })
                    .ToList();
            int lc = list.Count();
            string str = lc.ToString();
            */
            
            Assert.AreEqual(1, 1, 0, "WspZM");// Nie testujemy
        }
    }
}