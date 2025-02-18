using System.Collections;

namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Generic Collections

            //Add        AddRange 
            // Will Add In The Last



            ArrayList arrayList = new ArrayList();
            // in This Time Allocate 0 Count And 0 Capacity
            Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})");  // 0 , 0

            arrayList.Add( 1 ); // Boking
            // Will Allocate 4 Capacity And Allocate 1 Count
            Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})"); // 4 ,1

            arrayList.AddRange(new int[] { 1,2,3});
            // Will Allocate 4 Capacity And 4 Count
            Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})"); //  5 , 5

            arrayList.Add(10);
            // Will Duplicate Capacity For 8 And Count Will Increase 1
            Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})");  // 8 , 5

            //foreach (int i in arrayList) { Console.WriteLine(i); }  // UnBoking

            // TrimToSize =>>>>>>> This Func Will Remove lacer This is Empty From ArrayList 
            // arrayList.TrimToSize();

            #region Remove
            //arrayList.Remove(1); // In This Case Will Remove The First Occeure For 1
            //arrayList.RemoveAt(0); // In This Case Will Remove The Object In Index 0
            //arrayList.RemoveRange(0, 2); //in this case will remove from index 0  ===>>>> 2 numbers
            //Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})");
            #endregion

            #region Disadvantage ArrayList
            arrayList.Add("Route");

            // in this case will occure error because the data type 
            // TO HANDLE THIS ERROR LOOK TO THE NEXT FOREACH    
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            foreach (var i in arrayList)
            { Console.WriteLine(i); }
            #endregion

            #endregion
        }
    }
}
