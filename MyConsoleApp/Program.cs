using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
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



