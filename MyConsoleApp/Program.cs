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
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }

    class Program
    {
        delegate void Rule(User user);

        private static void LongNameRule(User user)
        {
            if (user.Name.Length > 10)
            {
                user.Name = user.Name.Substring(0, 10);
            }
        }

        private static void IncreaseAge(User user)
        {
            user.Age++;
        }

        private static List<User> TransformUsersByRule(List<User> users, Rule rule)
        {
            foreach (User user in users) 
            {
                rule(user);
            }
            return users;
        }

        static void Main()
        {
            List<User> users = new List<User>
            {
                new User("namenamename", 25),
                new User("1234567890", 34),
                new User("123456", 14),
            };

            List<User> transformedUsers = TransformUsersByRule(users, LongNameRule);

            transformedUsers = TransformUsersByRule(users, IncreaseAge);

            foreach (var user in transformedUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}
