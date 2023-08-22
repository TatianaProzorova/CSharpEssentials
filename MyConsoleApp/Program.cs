using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Security.Policy;
using System;
using System.Diagnostics;

namespace MyConsoleApp
{
    class Program
    {
        delegate void MeasureMethod(int repeatCount);

        static void Main()
        {
            MeasureMethod method1 = StringMeasure;
            Measure(method1);

            MeasureMethod method2 = StringBuilderMeasure;
            Measure(method2);
        }

        private static void Measure(MeasureMethod measureMethod)
        {
            int repeatCount = 10000;

            Stopwatch time = Stopwatch.StartNew();

            measureMethod?.Invoke(repeatCount);

            time.Stop();
            Console.WriteLine(time.Elapsed.TotalMilliseconds);
        }

        private static void StringBuilderMeasure(int repeatCount)
        {
            StringBuilder stringBuilderResult = new StringBuilder("Test");
            for (int i = 0; i < repeatCount; i++)
            {
                stringBuilderResult.Append("{i}");
            }
        }

        private static void StringMeasure(int repeatCount)
        {
            string stringResult = "Test";
            for (int i = 0; i < repeatCount; i++)
            {
                stringResult += "{i}";
            }
        }
    }
}
