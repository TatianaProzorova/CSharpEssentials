using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;

namespace MyConsoleApp
{
    class Program
    {
        public enum Operations
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public static double Calc(double item1, double item2, Operations operation)
        {
            if (operation == Operations.Divide && item2 == 0)
            {
                throw new ArgumentException("Divide by zero exception");
            }

            switch (operation)
            {
                case Operations.Add: return item1 + item2;  
                case Operations.Subtract: return item1 - item2; 
                case Operations.Multiply: return item1 * item2; 
                case Operations.Divide: return item1 / item2;                  
                default: return 0;
            }
        }

        static void Main()
        {
            Console.WriteLine(Calc(2.5, 2, Operations.Add));
            Console.WriteLine(Calc(2.5, 2, Operations.Subtract));
        }
    }
}
