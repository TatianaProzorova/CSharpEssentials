using System;

namespace MyConsoleApp
{
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
}
