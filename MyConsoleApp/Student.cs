using System;

namespace MyConsoleApp
{
    public class Student
    {
        public string FirstName = "Неизвестное имя";
        public string LastName = "Неизвестная фамилия";
        public int Age;

        public Student()
        {
            FirstName = "Unknown FirstName";
            LastName = "Unknown LastName";
        }

        public string Print()
        {
            return FirstName + " " + LastName;
        }

        //public void Print()
        //{
        //    Console.WriteLine("{0, -10} {1, -10} {2, -5}", FirstName, LastName, Age);
        //}
    }
}