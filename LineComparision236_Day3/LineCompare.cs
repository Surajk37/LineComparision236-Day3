namespace LineComparision
{
    class LineCompare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome To Line Comparision Computation Program\n");
            Console.WriteLine("Enter a x1 and y1 co-ordinates");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter a x2 and Y2 co-ordinates");
            int x2=Convert.ToInt32(Console.ReadLine());
            int y2=Convert.ToInt32(Console.ReadLine());

            double lengthofLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Distance Formula
            Console.WriteLine("\nLength of Line is : {0}",lengthofLine);
            Console.ReadLine();
        }
    }
}