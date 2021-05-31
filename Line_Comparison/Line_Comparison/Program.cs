using System;

namespace Line_Comparison
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Computation");
            Line line1 = new Line();
            double Line1 = line1.LengthOfLine(0, 0, 2, 2);
            Line line2 = new Line();
            double Line2 = line2.LengthOfLine(0, 0, 4, 4);
            //using equals
            if (line1.Equals(line2))
                Console.WriteLine("lines are equal");
            else
                Console.WriteLine("lines are not equal");
        }
    }
}
