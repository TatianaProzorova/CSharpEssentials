using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{

    public class Program
    {
        public class A
        {
            static A()
            {
                Console.WriteLine("Да! Я понял как создавать статический конструктор!");
            }
        }
        static void Main()
        {

        }
    }
}



