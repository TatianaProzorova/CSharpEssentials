using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;

namespace MyConsoleApp
{
    class Program
    {
        public class MyClass
        {
            public void Method1()
            {

            }
        }
        
        static void Main()
        {
            try
            {
                MyClass action = new MyClass();
                action.Method1();
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
