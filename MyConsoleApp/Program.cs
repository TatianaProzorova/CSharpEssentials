using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;

namespace MyConsoleApp
{
    class Program
    {
        static void Main()
        {
            try
            {
                WriteToFile();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Дальнейшеее выполнение программы");
        }
    }
}
