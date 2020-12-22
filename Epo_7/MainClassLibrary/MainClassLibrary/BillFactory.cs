using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public class BillFactory
    {
        public static Goods Create(string type, string item_name)
        {
            DateTime current = DateTime.Now;
            return DefaultCreate(type, item_name);
        }

        public static Goods Create(string type, string item_name, DateTime date)
        {
            DateTime current = date;
            return AddingTime(type, item_name, current);
        }

        public static Goods AddingTime(string type, string item_name, DateTime date)
        {
            Goods g;
            DateTime dt = date;
            DateTime b = new DateTime(dt.Year + 1, 1, 1); //new year
            int duration = (b - dt).Days;
            if (duration > 14){ g = DefaultCreate(type, item_name);}
            else { g = NewYearCreate(type, item_name);}
            return g;
        }

        public static Goods DefaultCreate(string type, string item_name)
        {
            switch (type)
            {
                case "REG":
                    return new Goods(item_name, new PercentForQuantity(2, 0.03), new FixedAmount(0.05, 5), type);
                case "SAL":
                    return new Goods(item_name, new PercentForQuantity(3, 0.01), new FixedAmount(0.01, 0), type);
                case "SPO":
                    return new Goods(item_name, new PercentForQuantity(10, 0.005), new FixedAmount(0, 1), type);
                default:
                    throw new ArgumentException("We haven't such type of good yet");
            }
        }

        public static Goods NewYearCreate(string type, string item_name)
        {
            switch (type)
            {
                case "REG":
                    return new Goods(item_name, new PercentForQuantity(2, 0.03), new AmountForSum(5000, 0.07, 5), type);
                case "SAL":
                    return new Goods(item_name, new PercentForSum(2000, 0.03), new FixedAmount(0.01, 0), type);
                case "SPO":
                    return new Goods(item_name, new PercentForSum(3000, 0.05), new FixedAmount(0, 1), type);
                default:
                    throw new ArgumentException("We haven't such type of good yet");
            }
        }
    }
}
