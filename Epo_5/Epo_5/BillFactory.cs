using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_5
{
    public class BillFactory
    {
     public static Goods Create(string type, string item_name)
        {
            switch(type)
            {
                case "REG":
                    return new RegularItem(item_name);
                case "SAL":
                    return new SalesItem(item_name);
                case "SPO":
                    return new SpecialItem(item_name);
                default:
                    throw new Exception();
            }

           
        }
    }
}
