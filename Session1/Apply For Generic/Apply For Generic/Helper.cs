using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Generic
{
    internal class Helper
    {
        public static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y=temp;
        }
        public static void Swap(ref double x,ref double y)
        {
            double temp = x;
            x = y;
            y=temp;
        }
        public static void Swap(ref Point x,ref Point y)
        {
            Point temp = x;
            x = y;
            y=temp;
        }
    }
}
