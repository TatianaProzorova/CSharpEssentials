using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;

namespace MyConsoleApp
{
    class Program
    {
        public enum Colors
        {
            Red,
            Black,
            Yellow,
            White
        }

        public enum Languages
        {
            English,
            Russian
        }

        public static string ColorTranslate(Colors color, Languages language)
        {
            switch (color, language)
            {
                case (Colors.Red, Languages.Russian): return "Красный";
                case (Colors.Black, Languages.Russian): return "Чёрный";
                case (Colors.Yellow, Languages.Russian): return "Жёлтый";
                case (Colors.White, Languages.Russian): return "Белый";
                case (Colors.Red, Languages.English): return "Red";
                case (Colors.Black, Languages.English): return "Black";
                case (Colors.Yellow, Languages.English): return "Yellow";
                case (Colors.White, Languages.English): return "White";
                default: return String.Empty;
            }
        }

        static void Main()
        {
            Console.WriteLine(ColorTranslate(Colors.Red, Languages.Russian)); // Красный
            Console.WriteLine(ColorTranslate(Colors.Red, Languages.English)); // Red
        }
    }
}
