using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MainClassLibrary;
using System.Windows.Forms;
using MainForm;

namespace MainConsoleApp
{
    //static class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        string filename = getData("BillInfo.yaml");
    //        if (args.Length == 1)
    //            filename = args[0];
    //        Console.WriteLine(filename);
    //        Console.ReadKey();

    //    }
    //    public static string getData(string filename)
    //    {
    //        FileStream fs = new FileStream(filename, FileMode.Open);
    //        StreamReader sr = new StreamReader(fs);
    //        YAMLFile manager = new YAMLFile(sr);
    //        Customer customer = manager.GetCustomer();
    //        BillGenerator b = new BillGenerator(customer, new TXTPresenter());
    //        int cnt = manager.GetGoodsCount();
    //        Goods[] g = new Goods[cnt];
    //        for (int i = 0; i < cnt; i++)
    //        {
    //            g[i] = manager.GetNextGood();
    //        }
    //        int itemsQty = manager.GetItemsCount();
    //        for (int i = 0; i < itemsQty; i++)
    //        {
    //            b.addGoods(manager.GetNextItem(g));
    //        }
    //        return b.GenerateBill();
    //    }
    //}

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}


