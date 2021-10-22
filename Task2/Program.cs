using System;

namespace Task2
{
    class Program
    {
        static double Func(double x, double y)
        {
            return Math.Pow(x, 3) / (3 * y) + Math.Sqrt(Math.Pow(x, 3) - 8 * x) + (3 * Math.Sin(y)) / Math.Cos(x / y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Func(3, 3));
        }
    }
}
