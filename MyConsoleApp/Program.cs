using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    partial class Program
    {
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public User(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public static explicit operator User(int age)
            {
                return new User("Неизвестно", age);
            }

            public static implicit operator int(User user)
            {
                return user.Age;
            }
        }

        static void Main()
        {
            int age = 25;
            User user = (User)age;
            Console.WriteLine(user.Name + " " + user.Age); // Неизвестно 25

            User user2 = new User("Josef", 26);
            int age2 = user2;
            Console.WriteLine(age2); // 26
        }
    }
}



