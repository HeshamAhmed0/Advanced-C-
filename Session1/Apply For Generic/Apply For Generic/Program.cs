namespace Apply_For_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Generic Swap
            //int x = 10;
            //int y = 20;
            //Helper.Swap(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //object x = 10;
            //object y = 20;    // Boking
            //Helper.Swap(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //object P1 = new Point(1,2);
            //object P2 = new Point(4,3);
            //Helper.Swap(ref P2 ,ref P1);
            //Console.WriteLine(P1);
            //Console.WriteLine(P2); 
            #endregion

            #region Generic Swap
            //int x = 10;
            //int y = 20;
            //Helper.Swap<int>(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //double x = 10;
            //double y = 20;    
            //Helper.Swap<double>(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(4, 3);
            //Helper.Swap<Point>(ref P2, ref P1);
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            #endregion
        }
    }
}
