using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epo_6;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestsNewMethods
    {
        TXTPresenter txtPresenter;
        HTMLPresenter htmlPresenter;

        [SetUp]
        public void Setup()
        {
            txtPresenter = new TXTPresenter();
            htmlPresenter = new HTMLPresenter();
        }


        [Test]
        public void TestRegularItemWithoutDiscount()
        {
            Goods pepsi = BillFactory.Create("REG", "pepsi");


            Item i1 = new Item(pepsi, 1, 65);
            Customer x = new Customer("Ali", 10);
            //IPresenter p = new TXTPresenter();
            BillGenerator b1 = new BillGenerator(x, txtPresenter);
            b1.addGoods(i1);
            string actual = b1.GenerateBill();
            string expected = "Счет для Ali\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tpepsi\t\t65\t1\t65\t0\t65\t3\nСумма счета составляет 65\nВы заработали 3 бонусных баллов";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSpecialItemWithDiscount()
        {
            Goods Cola = BillFactory.Create("SPO", "Cola");
            Item i1 = new Item(Cola, 12, 65);
            Customer x = new Customer("Ana", 10);
            //IPresenter p = new TXTPresenter();
            BillGenerator b1 = new BillGenerator(x, txtPresenter);
            b1.addGoods(i1);
            string actual = b1.GenerateBill();
            string expected = "Счет для Ana\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t12\t780\t3,9\t766,1\t0\nСумма счета составляет 766,1\nВы заработали 0 бонусных баллов";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestRegularItemAfterNewYearOffer()
        {
            Goods fanta = BillFactory.Create("REG", "fanta", DateTime.Parse("20.12.2020"));
            Item i1 = new Item(fanta, 1, 65.99);
            Customer x = new Customer("Sara", 0);
            //IPresenter p = new TXTPresenter();
            BillGenerator b1 = new BillGenerator(x, txtPresenter);
            b1.addGoods(i1);
            string actual = b1.GenerateBill();
            string expected = "Счет для Sara\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tfanta\t\t65,99\t1\t65,99\t0\t65,99\t0\nСумма счета составляет 65,99\nВы заработали 0 бонусных баллов";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestRegularItemWithinNewYearOffer()
        {
            Goods fanta = BillFactory.Create("REG", "fanta", DateTime.Parse("17.12.2020"));
            Item i1 = new Item(fanta, 1, 65.99);
            Customer x = new Customer("Sara", 0);
            //IPresenter p = new TXTPresenter();
            BillGenerator b1 = new BillGenerator(x, txtPresenter);
            b1.addGoods(i1);
            string actual = b1.GenerateBill();
            string expected = "Счет для Sara\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tfanta\t\t65,99\t1\t65,99\t0\t65,99\t3\nСумма счета составляет 65,99\nВы заработали 3 бонусных баллов";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSpecialItemAfterNewYearOffer()
        {
            Goods Cola = BillFactory.Create("SPO", "Cola", DateTime.Parse("20.12.2020"));
            Item i1 = new Item(Cola, 20, 0.39);
            Customer x = new Customer("Ana", 0);
            //IPresenter p = new TXTPresenter();
            BillGenerator b1 = new BillGenerator(x, txtPresenter);
            b1.addGoods(i1);
            string actual = b1.GenerateBill();
            string expected = "Счет для Ana\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t0,39\t20\t7,8\t0\t7,8\t0\nСумма счета составляет 7,8\nВы заработали 0 бонусных баллов";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSpecialItemWithinNewYearOffer()
        {
            Goods Cola = BillFactory.Create("SPO", "Cola", DateTime.Parse("17.12.2020"));
            Item i1 = new Item(Cola, 20, 0.39);
            Customer x = new Customer("Ana", 0);
            //IPresenter p = new TXTPresenter();
            BillGenerator b1 = new BillGenerator(x, txtPresenter);
            b1.addGoods(i1);
            string actual = b1.GenerateBill();
            string expected = "Счет для Ana\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t0,39\t20\t7,8\t0,039\t7,761\t0\nСумма счета составляет 7,761\nВы заработали 0 бонусных баллов";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSaleItemAfterNewYearOffer()
        {
            Goods Coffee = BillFactory.Create("SAL", "Coffee", DateTime.Parse("22.12.2020"));
            Item i1 = new Item(Coffee, 4, 14.50);
            Customer x = new Customer("Nouha", 0);
            //IPresenter p = new TXTPresenter();
            BillGenerator b1 = new BillGenerator(x, txtPresenter);
            b1.addGoods(i1);
            string actual = b1.GenerateBill();
            string expected = "Счет для Nouha\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCoffee\t\t14,5\t4\t58\t0\t58\t0\nСумма счета составляет 58\nВы заработали 0 бонусных баллов";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSaleItemWithinNewYearOffer()
        {
            Goods Coffee = BillFactory.Create("SAL", "Coffee", DateTime.Parse("17.12.2020"));
            Item i1 = new Item(Coffee, 4, 14.50);
            Customer x = new Customer("Nouha", 0);
            //IPresenter p = new TXTPresenter();
            BillGenerator b1 = new BillGenerator(x, txtPresenter);
            b1.addGoods(i1);
            string actual = b1.GenerateBill();
            string expected = "Счет для Nouha\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCoffee\t\t14,5\t4\t58\t0,58\t57,42\t0\nСумма счета составляет 57,42\nВы заработали 0 бонусных баллов";
            Assert.AreEqual(expected, actual);
        }


    }
}


