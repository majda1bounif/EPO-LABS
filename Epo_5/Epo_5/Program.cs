using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filename = getData("BillInfo.yaml");
            if (args.Length == 1)
                filename = args[0];
            Console.WriteLine(filename);
            Console.ReadKey();
            Console.ReadKey();
        }
        public static string getData(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            YAMLFile manager = new YAMLFile(sr);
            Customer customer = manager.GetCustomer();
            BillGenerator b = new BillGenerator(customer, new TXTPresenter());
            int cnt = manager.GetGoodsCount();
            Goods[] g = new Goods[cnt];
            for (int i = 0; i < cnt; i++)
            {
                g[i] = manager.GetNextGood();
            }
            int itemsQty = manager.GetItemsCount();
            for (int i = 0; i < itemsQty; i++)
            {
                b.addGoods(manager.GetNextItem(g));
            }
            return b.GenerateBill();
        }
    }
}

 