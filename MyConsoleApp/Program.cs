using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;

namespace MyConsoleApp
{
    class Program
    {
        public class Phone
        {
            public string Name { get; }
            public decimal Cost { get; }
            public Phone(string name, decimal cost)
            {
                if (name != null)
                    Name = name;
                else throw new ArgumentNullException("Имя не может быть равно null!");

                if (name != String.Empty && name.Length >= 2 && name.Length <= 150)
                    Name = name;
                else throw new ArgumentException("Имя должно содержать от 2 до 50 символов!");

                if (cost > 0)
                    Cost = cost;
                else throw new ArgumentException("Значение цены должно быть положительным!");
            }
        }
        
        static void Main()
        {

            Console.WriteLine("Дальнейшеее выполнение программы");
        }
    }
}
