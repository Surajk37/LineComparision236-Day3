using System.Net.Http.Headers;

namespace LineComparision236
{
    class Comparision
    {
        public double xAxisStart, yAxisStart, xAxisEnd, yAxisEnd;
        public void PointValues()
        {
            Console.WriteLine("Enter X Start");
            xAxisStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y Start");
            yAxisStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X End");
            xAxisEnd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y End");
            yAxisEnd = Convert.ToDouble(Console.ReadLine());
        }

        public double GetLength()
        {
            double length = Math.Sqrt(Math.Pow((xAxisEnd - xAxisStart), 2) + Math.Pow((yAxisEnd - yAxisStart), 2)); //Distance Formula
            return length;
        }
    }
    class LineCompare
    {
        static void Main(string[] args)
        {

            Comparision firstLine = new Comparision();
            Comparision secondLine = new Comparision();
            firstLine.PointValues();
            double firstLineLength = firstLine.GetLength();
            Console.WriteLine("Length of first Line: " + firstLineLength+"\n");
            secondLine.PointValues();
            double secondLineLength = secondLine.GetLength();
            Console.WriteLine("Length of Second Line: " + secondLineLength);
            if (firstLineLength.CompareTo(secondLineLength) > 0)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if (firstLineLength.CompareTo(secondLineLength) == 0)

            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
            Console.ReadLine();
        }
    }
    
}