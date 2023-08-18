using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    public class Profile
    {
        public string ProfessionName { get; }

        public Profile(string professionName)
        {
            ProfessionName = professionName;
        }

        protected virtual string GetInfo()
        {
            return String.Empty;
        }

        public void Describe()
        {
            Console.WriteLine($"{ProfessionName}, {GetInfo()}");
        }

        // code in Main()
        //    List<Profile> profiles = new List<Profile>
        //    {
        //        new Vacancy("C# разработчик", 100000),
        //        new Vacancy("Python разработчик", 90000),
        //        new Vacancy("C++ разработчик", 110000),
        //        new Resume("C# разработчик", 4),
        //        new Resume("C++ разработчик", 1),
        //    };

        //    foreach (var profile in profiles)
        //    {
        //        profile.Describe();
        //    }
    }
}



