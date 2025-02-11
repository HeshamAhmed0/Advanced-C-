using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Generic
{
    internal class Helper<T>
    {
        #region Swap
        #region Generic Swap
        //public static void Swap<T>(ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static int SearchArray(T[] numbers, int value)
        //{
        //    if (numbers is not null)
        //    {
        //        foreach (T i in numbers)
        //        {
        //            if (i == value)
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;

        //}
        #endregion

        #region Non Generic Swap
        //public static void Swap(ref object x,ref object y)
        //{
        //    object temp = x;
        //    x = y;
        //    y=temp;
        //}
        //public static void Swap(ref double x,ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y=temp;
        //}
        //public static void Swap(ref Point x,ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y=temp;
        //} 
        #endregion
    } 
    #endregion
}
