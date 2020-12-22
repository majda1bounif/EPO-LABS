using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_4
{
    public class HTMLPresenter : IPresenter
    {
        //The Header
        public string GetHeader()
        {
            throw new NotImplementedException();
        }

        //The Footer
        public string GetFooter(double totalAmount, int totalBonus)
        {
            throw new NotImplementedException();
        }
        //String of Items
        public string GetItemString(double discount, int bonus, double thisAmount, Item item)
        {
            throw new NotImplementedException();
        }
    }
}
