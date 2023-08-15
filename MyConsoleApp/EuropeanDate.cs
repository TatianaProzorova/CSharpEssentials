namespace MyConsoleApp
{
    public class EuropeanDate : BaseDate
    {
        public EuropeanDate(int year, int month, int day) : base(year, month, day)
        { }

        public override string GetFormat()
        {
            return $"{string.Format("{0:00}", Day)}.{string.Format("{0:00}", Month)}.{Year}";
        }
    }
}
