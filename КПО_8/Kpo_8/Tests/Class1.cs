using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo_8;
using NUnit.Framework;

namespace Tests
{[TestFixture]
    public class Class1
    {   [Test]
        public void TestPriceBySubscribe()
        {
            Subject book = new Subject("La petite chaperon rouge ", 1000);
            book.Price = 900;
            Observer obs = new Observer("Ana");
            book.registerObserver(obs);
            string actual = obs.GeInfo(book).ToString();
            string expected = "Hello  Ana!\nLa petite chaperon rouge   is now available at 900 with Discount  = -11,11111%"; 
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void TestPriceByUnSubscribe()
        {
            Subject book = new Subject("La petite chaperon rouge ", 1000);
            book.Price = 950;
            Observer obs = new Observer("Ana");
            book.unregisterObserver(obs);
            string actual = obs.GeInfo(book).ToString();
            string expected = "Hello  Ana!\nLa petite chaperon rouge   is now available at 950 with Discount  = -5,263158%";
            Assert.AreEqual(actual, expected);
        }
    }
}