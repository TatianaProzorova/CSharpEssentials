using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;

namespace MyConsoleApp
{
    class Program
    {
        public enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public static int GetDay(Months month)
        {
            return DateTime.DaysInMonth(2023, (int)month + 1); // enum index starts from zero
        }

        static void Main()
        {
                Console.WriteLine($"{GetDay(Months.February)}");
        }
    }
}
