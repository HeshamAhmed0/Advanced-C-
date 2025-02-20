using System.Collections;
using System.Collections.ObjectModel;

namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Generic Collections ArrayList

            //Add        AddRange 
            // Will Add In The Last



            //ArrayList arrayList = new ArrayList();
            //// in This Time Allocate 0 Count And 0 Capacity
            //Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})");  // 0 , 0

            //arrayList.Add( 1 ); // Boking
            //// Will Allocate 4 Capacity And Allocate 1 Count
            //Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})"); // 4 ,1

            //arrayList.AddRange(new int[] { 1,2,3});
            //// Will Allocate 4 Capacity And 4 Count
            //Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})"); //  5 , 5

            //arrayList.Add(10);
            //// Will Duplicate Capacity For 8 And Count Will Increase 1
            //Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})");  // 8 , 5

            ////foreach (int i in arrayList) { Console.WriteLine(i); }  // UnBoking

            //// TrimToSize =>>>>>>> This Func Will Remove lacer This is Empty From ArrayList 
            //// arrayList.TrimToSize();

            #region Remove
            //arrayList.Remove(1); // In This Case Will Remove The First Occeure For 1
            //arrayList.RemoveAt(0); // In This Case Will Remove The Object In Index 0
            //arrayList.RemoveRange(0, 2); //in this case will remove from index 0  ===>>>> 2 numbers
            //Console.WriteLine($"({arrayList.Capacity} , {arrayList.Count})");
            #endregion

            #region Disadvantage ArrayList
            //arrayList.Add("Route");

            // in this case will occure error because the data type 
            // TO HANDLE THIS ERROR LOOK TO THE NEXT FOREACH    
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (var i in arrayList)
            //{ Console.WriteLine(i); }
            #endregion

            #endregion

            #region Generic Collection List<T>
            List<int> list = new List<int>();
            Console.WriteLine($"({list.Capacity} , {list.Count})");  // 0 , 0
            list.Add(1);
            Console.WriteLine($"({list.Capacity} , {list.Count})"); // 4 , 1
            list.AddRange(2, 3, 4);
            Console.WriteLine($"({list.Capacity} , {list.Count})"); // 4, 4
            list.Add(10);
            Console.WriteLine($"({list.Capacity} , {list.Count})"); // 8 ,5

            #region Insert
            //list.Insert(1, 10);
            //foreach( int i in list)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region Remove
            //list.Remove(0); // in ths case will remove the value 0
            //list.RemoveAt(0); // in this case will remove the value in index 0
            //list.RemoveRange(0, 10); // in this case will remove from index 0  10 items
            #endregion

            #region AsReadOnly
            //ReadOnlyCollection<int> read=list.AsReadOnly();
            //Console.WriteLine(read);
            #endregion

            #region BinarySearch
            //int Index=list.BinarySearch(10);
            //Console.WriteLine(Index);

            #endregion

            #region Clear()
            //list.Clear();   // in this case the list will be deleted
            #endregion

            #region Remove()
            //list.Remove(0);  // in this case the value 0 wil be deleted
            //list.RemoveAt(0);  // in this case value in index 0 will bedeleted
            //list.RemoveRange(0, 10); //in this case will start from index 0  and delete 10 items
            #endregion

            #region Index
            int index=list.IndexOf(10);
            #endregion

            #endregion
        }
    }
}
