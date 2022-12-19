namespace LineComparision
{
    class LineCompare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome To Line Comparision Computation Program\n");
            Console.WriteLine("Enter First Line co-ordinates of x1,y1,x2,y2");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Line co-ordinates of x3,y3,x4,y4");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            double lengthofLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Distance Formula
            double lengthofLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)); 
            Console.WriteLine("\nThe Length Of First Line  = " + lengthofLine1);
            Console.WriteLine("The Length of Second Line = " + lengthofLine2 +"\n");

            int check = lengthofLine1.CompareTo(lengthofLine2); //Comparing two lines by using 'CompareTo' method 
            Console.WriteLine(check);
            if (check > 0)
                Console.WriteLine("Line 1 is Greater");
            else if (check < 0)
                Console.WriteLine("Lines 2 is Greater");
            else
                Console.WriteLine("Both are Equal");
                Console.ReadLine();
        }
    }
}