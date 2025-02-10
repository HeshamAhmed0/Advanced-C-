namespace Apply_For_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;
            //Helper.Swap(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //double x = 10;
            //double y = 20;
            //Helper.Swap(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            Point P1 = new Point(1,2);
            Point P2 = new Point(4,3);
            Helper.Swap(ref P2 ,ref P1);
            Console.WriteLine(P1);
            Console.WriteLine(P2);
        }
    }
}
