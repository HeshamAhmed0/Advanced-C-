using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Delegete
{
    public delegate bool DelegeteFunc(int A, int B);
    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] Arr,DelegeteFunc delegeteFunc)
        {
            for (int i = 0; i < Arr.Length; i++) 
            {
                for (int j=0; j<Arr.Length-j-1;j++)
                {
                    if (delegeteFunc.Invoke(Arr[j], Arr[j+1]))
                    {
                        Swap(ref Arr[j],ref Arr[j+1]);
                    }
                }
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
