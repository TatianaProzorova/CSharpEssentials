using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Security.Policy;
using System;
using System.Diagnostics;

namespace MyConsoleApp
{
    class Program
    {
        delegate bool Predicate(int age);

        static void Main()
        {
            //Predicate predicate = IsAdult;
            List<int> ages = new List<int> { 5,12,33,66};

            List<int> adults = GetAdults(ages, IsAdult);

            foreach (int adult in adults) 
            {
                Console.Write($"{adult} "); 
            }

            //List<int> years = new List<int> { 13, 17, 18, 19, 20, 50 };

            //List<int> adults = GetAdults(years, IsAdult);

            //foreach (var adult in adults)
            //{
            //    Console.WriteLine(adult);
            //}
        }

        private static List<int> GetAdults(List<int> ages, Predicate predicate)
        {
            List<int> list = new List<int> { };
            foreach (int age in ages) 
            { 
                if (predicate(age)) 
                    list.Add(age);
            }

            return list;
        }

        private static bool IsAdult(int age)
        {
            return age >= 18;
        }
    }
}
