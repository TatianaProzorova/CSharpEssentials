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
            Predicate predicate = IsAdult;
            List<int> listOfAges = new List<int>() { 5,12,33,66}; 
           
            listOfAges = GetAdults(listOfAges, predicate);

            foreach (int age in listOfAges) 
            {
                Console.Write($"{age} "); 
            }
        }

        private static List<int> GetAdults(List<int> ages, Predicate predicate)
        {
            List<int> list = new List<int>();
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
