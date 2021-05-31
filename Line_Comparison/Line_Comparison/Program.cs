using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Line line1 = new Line();
            Line line2 = new Line();
            double FirstLine = line1.LengthOfLine(0, 0, 2, 2);
            double SecondLine = line2.LengthOfLine(0, 0, 4, 4);

            //using Equals
            if (FirstLine.Equals(SecondLine))
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");

            //using compareTo
            double comparison = (FirstLine.CompareTo(SecondLine));
            if (comparison == 0)
            {
                Console.WriteLine("Lines are same length");
            }
            else
            {
                Console.WriteLine("Lines are not same length");
            }
        }
    }
}