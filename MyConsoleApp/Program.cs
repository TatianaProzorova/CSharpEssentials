using MyConsoleApp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class User
    {
        public string Name { get; set; }
        public User(string name) 
        {
            Name = name;
        }
        public void SendMessage(User user, string message)
        { }
        public void Post(string message)
        { }
        public string GetInfo()
        { 
            return $"Имя={Name}";
        }
    }

    public class Person : User
    {
        public int Age { get; set; }
        public Person (string name, int age) : base(name)
        {
            Age = age;
        }
        public new string GetInfo()
        {
            return $"Имя={Name}, Возраст={Age}";
        }
        public void Subscribe(User user)
        { }
    }

    public class Community : User
    {
        string Description { get; set; }
        public Community(string name, string description) : base(name) 
        {
            Name = name;
            Description = description;
        }
        public new string GetInfo()
        {
            return $"Имя={Name}, Описание={Description}";
        }
    }

    class Program
    {
        static void Main()
        {
            // Add code here
        }
    }
}