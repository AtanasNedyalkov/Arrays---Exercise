using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers = string.Empty;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                sum += newNumber;
                numbers += newNumber + " ";
            }
            Console.Write(numbers);
            Console.WriteLine();
            Console.WriteLine(sum);
            


        }
    }
}
