using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    public interface IUsersStorage
    {
        List<User> GetAll();
        User TryGetById(int id);
        void Add(User user);
    }


    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
