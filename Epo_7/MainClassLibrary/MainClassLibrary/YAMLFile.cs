using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MainClassLibrary
{
   public class YAMLFile : AbstractContentFile
    {
        protected string line;
        protected string _source;
        protected TextReader sr;


        public YAMLFile(TextReader source) => SetSource(source);

        public override void SetSource(TextReader source) => sr = source;

        private string GetNextLine()
        {
            string line;
            do
            {
                line = sr.ReadLine();
            } while (line.StartsWith("#"));

            if (line == null) throw new Exception();
            return line;

        }
        public override Customer GetCustomer()
        {
            string line = GetNextLine();
            string[] result = line.Split(':');
            string name = result[1].Trim();
            line = sr.ReadLine();
            result = line.Split(':');
            int bonus = Convert.ToInt32(result[1].Trim());
            return new Customer(name, bonus);
        }
        public override int GetGoodsCount()
        {

            string line = GetNextLine();
            string[] result = line.Split(':');
            return Convert.ToInt32(result[1].Trim());
        }
        public override Goods GetNextGood()
        {
            string line = GetNextLine();
            string[] result = line.Split(':');
            result = result[1].Trim().Split();
            string type = result[1].Trim();

            return BillFactory.Create(type, result[0]);
        }
        public override int GetItemsCount()
        {
            string line = GetNextLine();
            string[] result = line.Split(':');
            return Convert.ToInt32(result[1].Trim());
        }

        public override Item GetNextItem(Goods[] good)
        {
            string line = GetNextLine();
            string[] result = line.Split(':');
            result = result[1].Trim().Split();
            int Goods_Id = Convert.ToInt32(result[0].Trim());
            double price = Convert.ToDouble(result[1].Trim());
            int quantity = Convert.ToInt32(result[2].Trim());
            return new Item(good[Goods_Id-1], quantity, price);
        }

    }
}



