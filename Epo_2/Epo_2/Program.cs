using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods OrangeJus = new Goods("OrangeJus", Goods.SALE);
            Item i1 = new Item(OrangeJus, 4, 65);
            Customer x = new Customer("David", 10);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            Console.WriteLine("nmbndbewdbebd"+i1.GetDiscount()+"\n"+"\n");
            string actual = b1.Statement();
            Console.WriteLine(actual);
            Console.ReadKey();

        }
    }
}
