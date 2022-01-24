using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle area calculation

            // Rectangle values
            int sideA = 10;
            int sideB = 20;

            // Rectangle area formula is a*b
            int area = sideA * sideB;

            Console.WriteLine(area);



            // Rectangle area calculation with float value

            // Rectangle values
            float sideC = 10.0f;
            int sideD = 80;
            sideD++;

            // Rectangle area formula is a*b
            float areaWithFloat = sideC * sideD;

            Console.WriteLine(areaWithFloat);
            Console.WriteLine("The rectangle area is: " + areaWithFloat);

            // Other operators: + - / * % ++ --
        }
    }
}
