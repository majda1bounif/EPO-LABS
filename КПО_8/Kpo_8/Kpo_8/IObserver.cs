using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_8
{
    public interface IObserver
    {
        void update(Subject sub);
    }
}
