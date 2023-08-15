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
        int Item { get; set; }

        public Summator()
        {
            Item = Transform(Item);
        }

        protected virtual int Transform(int item)
        {
            return item;
        } 

        public int Sum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Transform(i);
            }

            return sum;
        }
    }

    public class SquareSummator : Summator
    {
        public SquareSummator() : base() 
        { }

        protected override int Transform(int item)
        {
            return item * item;
        }
    }

    public class CubeSummator : Summator
    {
        public CubeSummator() : base()
        { }

        protected override int Transform(int item)
        {
            return item * item * item;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Summator().Sum(5)); // 15
            Console.WriteLine(new SquareSummator().Sum(5)); // 55
            Console.WriteLine(new CubeSummator().Sum(5)); // 225

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
