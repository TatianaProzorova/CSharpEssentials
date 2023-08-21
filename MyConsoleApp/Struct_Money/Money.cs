using System;

namespace MyConsoleApp
{
    public partial class Program
    {
        public struct Money
        {
            private decimal ruble;
            private decimal kopeck;
            public decimal Ruble 
            {
                get { return ruble; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Rubles must not be < 0");
                    }
                    else ruble = value;
                }
            }

            public decimal Kopeck
            {
                get { return kopeck; }
                set
                {
                    if (value < 0 || value > 99) 
                    {
                        throw new Exception("Kopecks are out of range [0;99]");
                    }
                    else kopeck = value;
                }
            }

            public Money(decimal ruble, decimal kopeck)
            {                
                this.ruble = ruble;
                this.kopeck = kopeck;
                Ruble = ruble; 
                Kopeck = kopeck; 
            }

            public override string ToString()
            {
                return $"{ruble}, {string.Format("{0:00}", kopeck)}";
            }

            // code from Main()
            //Money money1 = new Money(10, 50);
            //Console.WriteLine(money1); // 10, 50

            //money1.Ruble = 4;
            //money1.Kopeck = 5;
            //Console.WriteLine(money1); // 4, 05

            //money1.Kopeck = 100; // ошибка
        }
    }
}
