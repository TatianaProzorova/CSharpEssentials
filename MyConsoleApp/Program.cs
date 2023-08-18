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
    }

    public class Vacancy : Profile
    {
        private int Compensation { get; }
        public Vacancy(string ProfessionName, int compensation) : base(ProfessionName)
        { 
            Compensation = compensation;
        }

        protected override string GetInfo()
        {
            return $"Предлагаемая зарплата: {Compensation}";  
        }
    }

    public class Resume : Profile
    {
        private int WorkExperience { get; }
        public Resume(string ProfessionName, int workExperience) : base(ProfessionName)
        { 
            WorkExperience = workExperience;
        }

        protected override string GetInfo()
        {
            return $"Стаж работы: {WorkExperience}";
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



