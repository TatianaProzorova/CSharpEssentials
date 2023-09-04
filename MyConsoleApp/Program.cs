using CSharpEssentials;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CSharpEssentials
{


    class Program
    {
        static void Main(string[] args)
        {
            static List<string> GetLongNames(List<string> names)
            {
                var longNames = names // источник
                                    .Where(name => name.Length > 3) // запрос
                                    .Select(name => name);

                return longNames.ToList();
            }
        }
    }
}
