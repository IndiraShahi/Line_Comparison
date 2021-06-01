using System;

namespace Line_Comparison
{
    class Line
    {

        public double LengthOfLine(int x1, int y1, int x2, int y2)
        {

            double LengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(LengthOfLine);
            return LengthOfLine;

        }
    }
}