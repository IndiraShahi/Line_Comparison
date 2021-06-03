using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Length Line;
            Line = new Length();
            double FirstLine = Line.LengthOfLine(0, 0, 2, 2);
            double SecondLine = Line.LengthOfLine(2, 2, 0, 0);

            //using Equals
            if (FirstLine.Equals(SecondLine))
                Console.WriteLine("Using Equlas : Lines are equal");
            else
                Console.WriteLine("Using Equlas : Lines are not equal");

            //using compareTo
            double comparison = (FirstLine.CompareTo(SecondLine));
            if (comparison == 0)
            {
                Console.WriteLine("Using compareTo : Lines are of same length");
            }
            else
            {
                Console.WriteLine("Using compareTo : Lines are not of same length");
            }
        }
    }
}