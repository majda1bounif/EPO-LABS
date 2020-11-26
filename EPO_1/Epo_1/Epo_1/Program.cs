using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods OrangeJus = new Goods("OrangeJus", Goods.SALE);
            Item i1 = new Item(OrangeJus, 4, 65);
            Customer x = new Customer("David", 10);
            RefBill b1 = new RefBill(x);
            b1.addGoods(i1);
            string bill = b1.Statement();
            Console.WriteLine(bill);
            Console.ReadKey();
        }  
    }
}