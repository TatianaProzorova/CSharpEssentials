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
    }
}
