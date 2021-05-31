using System;

namespace Line_Comparison
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Computation");
            Line line1 = new Line();
            double Line = line1.LengthOfLine(0, 0, 2, 2);
        }
    }
}
