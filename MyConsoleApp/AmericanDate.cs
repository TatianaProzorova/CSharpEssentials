namespace MyConsoleApp
{
    public class AmericanDate : BaseDate
    {
        public AmericanDate(int year, int month, int day) : base(year, month, day)
        { }

        public override string GetFormat()
        {
            return $"{string.Format("{0:00}", Month)}.{string.Format("{0:00}", Day)}.{Year}";
        }
    }
}
