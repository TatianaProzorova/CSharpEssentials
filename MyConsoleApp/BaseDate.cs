namespace MyConsoleApp
{
    public class BaseDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public BaseDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public virtual string GetFormat()
        {            
            return $"год:{Year}, месяц:{string.Format("{0:00}", Month)}, день:{string.Format("{0:00}", Day)}";
        }

        // call from Main()
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
