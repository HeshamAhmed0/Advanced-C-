using System.Collections;

namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Generic Collections
            ArrayList arrayList = new ArrayList();
            // in This Time Allocate 0 Count And 0 Capacity
            Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})");  // 0 , 0

            arrayList.Add( 1 );
            // Will Allocate 4 Capacity And Allocate 1 Count
            Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})"); // 4 ,1

            arrayList.AddRange(new int[] { 1,2,3});
            // Will Allocate 4 Capacity And 4 Count
            Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})"); //  5 , 5

            arrayList.Add(10);
            // Will Duplicate Capacity For 8 And Count Will Increase 1
            Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})");  // 8 , 5

            #endregion
        }
    }
}
