using MyConsoleApp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Word
    {
        /// <summary>
        /// Исходное слово
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Перевод исходного слова
        /// </summary>
        public string Target { get; set; }

        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
    public class Dictionary
    {
        private Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
                new Word("red", "красный"),
                new Word("blue", "синий"),
                new Word("green", "зеленый")
            };
        }

        public string this[string sourсe]
        {
            get
            {
                foreach (var word in words)
                {
                    if (word.Source == sourсe)
                        return word.Target;
                }

                return null;
            }

            set
            {
                foreach (var word in words)
                {
                    if (word.Source == sourсe)
                    {
                        word.Target = value;
                    }
                }
            }
        }
    }
    //=============================================
    public class Matrix
    {
        private int[,] numbers;
        public Matrix()
        {
            numbers = new int[,] {
                { 1, 2, 4 },
                { 2, 3, 6 },
                { 3, 4, 8 }
            };
        }

        public int this[int row, int column]
        {
            get 
            {
                if (row < 0 || row >= numbers.GetLength(0) || column < 0 || column >= numbers.GetLength(1))
                    throw new ArgumentException("One or more indexes are out of range");
                
                return numbers[row, column]; 
            } 
            set 
            {
                if (row < 0 || row >= numbers.GetLength(0) || column < 0 || column >= numbers.GetLength(1))
                    throw new ArgumentException("One or more indexes are out of range"); 
                
                numbers[row, column] = value; 
            }
        }
    }
    //=============================================
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("one or more invalid triangle sides");

            A = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return A + B + C;
        }
    }
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double a) : base(a, a, a)
        { }
    }
    //=============================================
    public class User
    {
        public string Name { get; set; }
        public User(string name) 
        {
            Name = name;
        }
        public void SendMessage(User user, string message)
        { }
        public void Post(string message)
        { }
        public string GetInfo()
        { 
            return $"Имя={Name}";
        }
    }

    public class Person : User
    {
        public int Age { get; set; }
        public Person (string name, int age) : base(name)
        {
            Age = age;
        }
        public new string GetInfo()
        {
            return $"Имя={Name}, Возраст={Age}";
        }
        public void Subscribe(User user)
        { }
    }

    public class Community : User
    {
        string Description { get; set; }
        public Community(string name, string description) : base(name) 
        {
            Name = name;
            Description = description;
        }
        public new string GetInfo()
        {
            return $"Имя={Name}, Описание={Description}";
        }
    }

    class Program
    {
        static void Main()
        {


        }
    }
}