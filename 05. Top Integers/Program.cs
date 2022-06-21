using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string arrayOfBigINts = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[i+1])
                {
                    arrayOfBigINts += array[i];
                }
            }
            Console.Write(arrayOfBigINts+" ");

        }
    }
}
