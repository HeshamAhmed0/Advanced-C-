namespace Apply_For_Delegete
{
    public delegate int CountFunc(string input);
    internal class Program
    {
        static void Main(string[] args) 
        {


            #region Example01
            //{
            //    CountFunc countFunc;
            //    countFunc = new CountFunc(StringFunctions.CountUpper);
            //    int Result = countFunc("HESHAM");
            //    Console.WriteLine(Result); 
            #endregion

            #region Example02
            //int[] Arr = { 5, 2, 3 ,6,8,9,2,4};
            //SortingAlgorithms<int>.BubbleSort(Arr,SortingTypes.COMPARELESS);
            //foreach (int i in Arr)
            //{
            //    Console.WriteLine(i);
            //}

            string[] names = { "Hesham", "Ahmed", "Ali","Hassan", "Ali" };
            SortingAlgorithms<string>.BubbleSort(names, SortingTypes.CompareStringsAsci);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            #endregion
        }
    }
}
