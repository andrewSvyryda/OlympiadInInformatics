using System;

namespace Task1
{
    class Program
    {
        static int GetDigitsSum(int num)
        {
            return num == 0 ? 0 : num % 10 + GetDigitsSum(num / 10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetDigitsSum(1344545345));
        }
    }
}
