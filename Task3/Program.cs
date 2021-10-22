using System;

namespace Task3
{
    class Program
    {
        static double Sum(int x, int count)
        {
            double res = 0;

            for (int i = 0; i < count * 2; i++)
            {
                int pow = i * 2 + 1;
                Console.WriteLine(res);
                res += Math.Pow(x, pow) / pow * (i % 2 == 0 ? 1 : -1);
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(22, 10));
        }
    }
}
