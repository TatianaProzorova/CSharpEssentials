using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Summator
    {
        public int Item { get; set; }

        protected virtual int Transform(int item)
        {
            return item;
        } 

        public int Sum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += Transform(i);

            return sum;
        }
    }

    public class SquareSummator : PowerSummator
    {
        public SquareSummator() : base(2) 
        { }
    }

    public class CubeSummator : PowerSummator
    {
        public CubeSummator() : base(3)
        { }
    }

    public class PowerSummator : Summator
    {
        protected int Power { get; set; } 
        public PowerSummator(int power)
        {
            Power = power;
        }

        protected override int Transform(int item)
        {
            return (int)Math.Pow(item, Power);
        }
    }


    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Summator().Sum(5)); // 15
            Console.WriteLine(new PowerSummator(1).Sum(5)); // 15

            Console.WriteLine(new SquareSummator().Sum(5)); // 55
            Console.WriteLine(new PowerSummator(2).Sum(5)); // 55

            Console.WriteLine(new CubeSummator().Sum(5)); // 225
            Console.WriteLine(new PowerSummator(3).Sum(5)); // 225

            //BaseDate date = new BaseDate(2021, 1, 13);
            //AmericanDate date1 = new AmericanDate(2021, 1, 6);
            //EuropeanDate date2 = new EuropeanDate(2021, 1, 6);

            //List<BaseDate> dates = new List<BaseDate>
            //{                                           // год:2021, месяц:03, день:24
            //    date, date1, date2                      // 03.24.2021
            //};                                          // 24.03.2021

            //foreach (var item in dates)
            //{
            //    Console.WriteLine(item.GetFormat());
            //}
        }
    }
}
