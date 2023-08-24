using System.Collections.Generic;
using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main()
        {
            Print(new List<int> { 1, 2, 3, 4, 5 }, Twice);
        }

        static void Print(List<int> items, Action<int> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }

        static void Twice(int item)
        {
            Console.Write($"{item * 2} ");
        }
    }
}
