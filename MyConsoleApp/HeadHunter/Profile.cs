using System;

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
}



