using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;
using System.Configuration;

namespace MyConsoleApp
{
    class Program
    {
        public class User
        {
            public string Name;
            public string Email;
            public string Password;

            public User(string name, string email, string password)
            {
                Name = name;
                Email = email;
                Password = password;
            }
        }

        public class UserManager
        {
            public List<User> Users {get;}
            
            public UserManager()
            {
                Users = new List<User>();
            }  
            
            public void Register(User user)
            {
                Users.Add(user);
            }
        }

        static void Main()
        {

        }
    }
}
