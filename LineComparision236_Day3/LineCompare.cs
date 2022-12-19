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
            Console.WriteLine("\nThe Length Of Line First  = " + lengthofLine1);
            Console.WriteLine("The Length of Line Second = " + lengthofLine2 +"\n");

            bool check = lengthofLine1.Equals(lengthofLine2);
            Console.WriteLine(check);
            if (check)
                Console.WriteLine("Both Lines are Equal");
            else
                Console.WriteLine("Lines are Not Equal");
                Console.ReadLine();
        }
    }
}