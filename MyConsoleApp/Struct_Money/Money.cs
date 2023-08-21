using System;

namespace MyConsoleApp
{
    public partial class Program
    {
        public struct Money
        {
            private int ruble;
            private int kopeck;
            public int Ruble { get; set; }

            public int Kopeck
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

            public Money(int ruble, int kopeck)
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

            public static Money operator +(Money money1, Money money2)
            {
                int resultKopeck = money1.ruble * 100 + money1.kopeck + money2.ruble * 100 + money2.kopeck;
                int resultRuble = resultKopeck / 100;
                resultKopeck %= 100;

                return new Money(resultRuble, resultKopeck);
            }

            public static Money operator -(Money money1, Money money2)
            {
                int resultKopeck = (money1.ruble * 100 + money1.kopeck) - (money2.ruble * 100 + money2.kopeck);
                int resultRuble = resultKopeck / 100; 
                
                if (resultKopeck < 0) {
                    resultKopeck = Math.Abs(resultKopeck);
                }                
                
                resultKopeck %= 100;

                return new Money(resultRuble, resultKopeck);
            }

            // code from Main()

            //Money money1 = new Money(10, 50);
            //Console.WriteLine(money1); // 10, 50

            //money1.Ruble = 4;
            //money1.Kopeck = 5;
            //Console.WriteLine(money1); // 4, 05

            //money1.Kopeck = 100; // ошибка

            //=================================

            //Money money1 = new Money(11, 51);
            //Money money2 = new Money(25, 90);

            //Money money3 = money1 + money2;
            //Console.WriteLine(money3); // 37, 41

            //Money money4 = money3 - money2;
            //Console.WriteLine(money4); // 11, 51

            //Money money5 = money1 - money2;
            //Console.WriteLine(money5); // -14, 39
        }
    }
}
