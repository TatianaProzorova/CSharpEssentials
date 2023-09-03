namespace CSharpEssentials
{
    public static class StringHelpers
    {
        public static int CharCount(this string sentense, char symbol)
        {
            int result = 0;
            
            foreach (char c in sentense)
            {
                if (c == symbol) result++;
            }

            return result;
        }

        // code from Main()
        //string s = "Hello world";
        //char c = 'l';
        //int i = s.CharCount(c);
        //Console.WriteLine(i); // 3
    }
}
