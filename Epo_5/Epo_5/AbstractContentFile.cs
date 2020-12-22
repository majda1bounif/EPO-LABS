using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_5
{
    public abstract class AbstractContentFile
    {
        public abstract void SetSource(TextReader textReader);

        public abstract Customer GetCustomer();

        public abstract int GetGoodsCount();

        public abstract Goods GetNextGood();

        public abstract int GetItemsCount();

        public abstract Item GetNextItem(Goods[] good);
    }
}







