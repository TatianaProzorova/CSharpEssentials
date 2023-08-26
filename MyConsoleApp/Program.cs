using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;
using System.Configuration;

namespace MyConsoleApp
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    
    public interface IStudent : IPerson
    {
        int Course { get; set; }
        void Learn(string subject);
    }

    class Program
    {

        static void Main()
        {

        }
    }
}
