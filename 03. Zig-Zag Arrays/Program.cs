using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] leftDiagonal = new int[n];
            int[] rightDiagonal = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2==0)
                {
                    leftDiagonal[i] = array[0];
                    rightDiagonal[i] = array[1];
                }
                else
                {
                    leftDiagonal[i] = array[1];
                    rightDiagonal[i] = array[0];
                }
            }
            Console.WriteLine(string.Join(" ", leftDiagonal));
            Console.WriteLine(string.Join(" ", rightDiagonal));
        }
    }
}
