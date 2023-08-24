using System.Collections.Generic;
using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main()
        {
            Func<int, bool> predicate = delegate (int number)
            {
                return Math.Pow(number, 2) % 10 == 9;
            };

            Print(new List<int> { 1, 2, 3, 4, 5, 7, 13, 27 }, predicate);
        }

        static void Print(List<int> items, Func<int, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
