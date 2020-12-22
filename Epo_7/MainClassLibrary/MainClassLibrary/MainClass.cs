using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{
    public static class ArrayUtils
    {
        public static int Sum(int[] arary)
        {
            int s = 0;
            foreach (int v in arary)
            {
                s += v;
            }
            return s;
        }
    }
}

