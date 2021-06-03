using System;

namespace Line_Comparison
{
        public abstract class Line
        {
            public abstract double LengthOfLine(int x1, int y1, int x2, int y2);
        }
        public class Length:Line
        {
            public override double LengthOfLine(int x1, int y1, int x2, int y2)
        {
            double LengthOfLine = 0;
            LengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length Of Line is=" +LengthOfLine);
            return LengthOfLine;

        }
    }
}