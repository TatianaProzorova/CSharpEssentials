using CSharpEssentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;

namespace CSharpEssentials
{
    public class FibonacciCounter
    {
        public void Count(long x)
        {
            var fibonacciNumbers = GetFibonacciNumbers(x);

            foreach (var number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }
        }

        private static List<BigInteger> GetFibonacciNumbers(long input)
        {
            var fibonacci = new List<BigInteger> ();
            BigInteger previous = 0; 
            BigInteger current = 1;
            BigInteger preliminarySum = 1;
            long count = fibonacci.Count;

            while (count < input)
            {
                fibonacci.Add(previous);
                
                preliminarySum = previous + current;
                previous = current;
                current = preliminarySum;                

                count++;
            }

            return fibonacci;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
