using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_8
{
    public class Observer :  IObserver
    {
        private string NameObserver;
        public Observer(string Name)
        {
            NameObserver = Name;
        }
        public void update(Subject sub)
        {
            GeInfo(sub);
        }
        public string GeInfo(Subject sub)
        {

            string info = "Hello  " + NameObserver + "!\n" + sub.Name + "  is now available at " + sub.Price + " with Discount  = " + sub.discount +"%";
            return info;
        }
        

    }
}