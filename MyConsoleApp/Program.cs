using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;
using System.Configuration;

namespace MyConsoleApp
{
    public interface IInterfaceA
    {
        bool Prop1 { get; set; }
        int Prop2 { get; set; }
    }

    public interface IInterfaceB
    {
        string Prop3 { get; set; }
        void Method1(string param);
    }

    public class MyClass : IInterfaceA, IInterfaceB
    {
        public bool Prop1 { get; set; }
        public int Prop2 { get; set; }
        public string Prop3 { get; set; }
        public void Method1(string param)
        {
            // some logic
        }
    }

    class Program
    {
        static void Main()
        {

        }
    }
}
