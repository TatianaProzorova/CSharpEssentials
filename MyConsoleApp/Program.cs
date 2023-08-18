using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Profile
    {
        public string ProfessionName { get; set; }

        public Profile(string professionName)
        {
            ProfessionName = professionName;
        }

        protected virtual string GetInfo()
        {
            return String.Empty;
        }

        public void Describe(string professionName)
        {
            string result;
            result = GetInfo();
            Console.WriteLine($"{professionName}, {result}");
        }            
    }

    public class Vacancy : Profile
    {
        private int Compensation { get; }
        public Vacancy(string ProfessionName, int Compensation) : base(ProfessionName)
        { }

        protected override string GetInfo()
        {
            return $"Предлагаемая зарплата: {Compensation}";  
        }
    }

    class Program
    {
        static void Main()
        {
            List<Profile> profiles = new List<Profile>
            {
                new Vacancy("C# разработчик", 100000),
                new Vacancy("Python разработчик", 90000),
                new Vacancy("C++ разработчик", 110000),
                new Resume("C# разработчик", 4),
                new Resume("C++ разработчик", 1),
            };

            foreach (var profile in profiles)
            {
                profile.Describe();
            }
        }
    }
}



