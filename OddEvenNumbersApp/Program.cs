using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintNumbers("All numbers ",numbers);
            PrintNumbers("Even numbers ", numbers.Where(n => IsEven(n)));
            PrintNumbers("Odd numbers ", numbers.Where(n => IsOdd(n)));

        }
        static void PrintNumbers(string message , IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{message}: [ ");
            foreach(var num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine(" ]");
        }
        static bool IsOdd(int num) => num % 2 == 1;
        static bool IsEven(int num) => num % 2 == 0;
    }
}