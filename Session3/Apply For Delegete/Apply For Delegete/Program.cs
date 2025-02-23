namespace Apply_For_Delegete
{
    public delegate int CountFunc(string input);
    internal class Program
    {
        static void Main(string[] args) 
        {


            #region Deegete
            //{
            //    CountFunc countFunc;
            //    countFunc = new CountFunc(StringFunctions.CountUpper);
            //    int Result = countFunc("HESHAM");
            //    Console.WriteLine(Result); 
            #endregion

            #region Sorting Algorithm
            int[] Arr = { 5, 2, 3 ,6,8,9,2,4};
            SortingAlgorithms.BubbleSort(Arr,SortingTypes.COMPARELESS);
            foreach (int i in Arr)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
