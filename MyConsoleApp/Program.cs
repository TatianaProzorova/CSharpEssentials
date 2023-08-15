using System;
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
            BaseDate date = new BaseDate(2021, 1, 13);
            AmericanDate date1 = new AmericanDate(2021, 1, 6);
            EuropeanDate date2 = new EuropeanDate(2021, 1, 6);

            List<BaseDate> dates = new List<BaseDate>
            {                                           // год:2021, месяц:03, день:24
                date, date1, date2                      // 03.24.2021
            };                                          // 24.03.2021

            foreach (var item in dates)
            {
                Console.WriteLine(item.GetFormat());
            }
        }
    }
}
