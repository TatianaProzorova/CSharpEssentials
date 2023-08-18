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

        // call in Main()
        //Console.WriteLine(new Summator().Sum(5)); // 15
        //Console.WriteLine(new PowerSummator(1).Sum(5)); // 15

        //Console.WriteLine(new SquareSummator().Sum(5)); // 55
        //Console.WriteLine(new PowerSummator(2).Sum(5)); // 55

        //Console.WriteLine(new CubeSummator().Sum(5)); // 225
        //Console.WriteLine(new PowerSummator(3).Sum(5)); // 225
    }
}
