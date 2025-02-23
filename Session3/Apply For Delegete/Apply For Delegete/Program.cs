namespace Apply_For_Delegete
{
    public delegate int CountFunc(string input);
    internal class Program
    {
        static void Main(string[] args)
        {
            CountFunc countFunc;
            countFunc = new CountFunc(StringFunctions.CountUpper);
            int Result = countFunc("HESHAM");
            Console.WriteLine(Result);
        }
    }
}
