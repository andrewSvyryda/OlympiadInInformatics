using System;

namespace Task4
{
    class Program
    {
        static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static int[][] CopyArray(int [][] arr)
        {
            int[][] tmp = new int[arr.Length][];

            for (int i = 0; i < arr.Length; i++)
            {
                tmp[i] = new int[arr[i].Length];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    tmp[i][j] = arr[i][j];
                }
            }

            return tmp;
        }

        static int[][] ReplaceNumbers(int[][] arr)
        {
            int[][] tmp = CopyArray(arr);

            for (int i = 0; i < tmp.Length; i++)
            {
                for (int j = 0; j < tmp[i].Length; j++)
                {
                    tmp[i][j] = tmp[i][j] > 0 ? 1 : 0;
                }
            }

            return tmp;
        }

        static double FindSumOfPow(int[][] arr)
        {
            double res = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if(arr[i][j] > 0 && arr[i][j] % 2 == 0)
                    {
                        res += Math.Pow(arr[i][j], 2);
                    }
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            int[][] arr = new int[5][];

            arr[0] = new int[] { 22, 215, 0, -4, 28, 125 };
            arr[1] = new int[] { 87, 44, -22, 7, 123, -39 };
            arr[2] = new int[] { -9, -5, 0, 63, -17, 45 };
            arr[3] = new int[] { 21, -3, -4, -8, 9, -122 };
            arr[4] = new int[] { -21, -8, -5, 45, 32, 88 };

            int[][] tmp = ReplaceNumbers(arr);

            PrintArray(arr);
            Console.WriteLine();
            PrintArray(tmp);
            Console.WriteLine();

            double res = FindSumOfPow(arr);
            Console.WriteLine(res);
        }
    }
}
