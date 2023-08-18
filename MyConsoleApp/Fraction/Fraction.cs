using System;
using System.Diagnostics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace MyConsoleApp
{
    public class Fraction
    {
        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator;

        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator;

        /// <summary>
        /// Целая часть дроби
        /// </summary>
        public int IntegerPart;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            IntegerPart = 0;
        }

        public Fraction(int integerPart)
        {
            Numerator = 1;
            Denominator = 1;
            IntegerPart = integerPart;
        }

        public void Print()
        {
            if (IntegerPart == 0)
            {
                
                Console.WriteLine($"{Numerator}/{Denominator}");
            }                
            else if (Denominator == 0)
                Console.WriteLine($"{IntegerPart}");
            else Console.WriteLine($"{IntegerPart} {Numerator}/{Denominator}");
        }

        public Fraction Sum(Fraction otherFraction)
        {
            int commonDenomenator = Denominator * otherFraction.Denominator;

            int resultNumerator = Numerator * otherFraction.Denominator + otherFraction.Numerator * Denominator;

            Fraction result = new Fraction(resultNumerator, commonDenomenator);

            return FractionReduce(result);
        }

        public Fraction Sum(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);

            Fraction result = Sum(otherFraction);
            return result;
        }

        public Fraction Difference(Fraction otherFraction)
        {
            int commonDenomenator = Denominator * otherFraction.Denominator;

            int resultNumerator = Numerator * otherFraction.Denominator - otherFraction.Numerator * Denominator;

            Fraction result = new Fraction(resultNumerator, commonDenomenator);
            return result;
        }

        public Fraction Difference(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);

            Fraction result = Difference(otherFraction);
            return result;
        }

        public Fraction Multiply(Fraction otherFraction)
        {
            Fraction result = new Fraction(Numerator * otherFraction.Numerator, Denominator * otherFraction.Denominator);
            return result;
        }

        public Fraction Multiply(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);

            Fraction result = Multiply(otherFraction);
            return result;
        }

        public Fraction Divide(Fraction otherFraction)
        {
            Fraction result = new Fraction(Numerator * otherFraction.Denominator, Denominator * otherFraction.Numerator);
            return result;
        }

        public Fraction Divide(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);

            Fraction result = Divide(otherFraction);
            return result;
        }

        public Fraction FractionWithInteger(int number)
        {
            Fraction result = new Fraction(number);
            return result;
        }
        public Fraction FractionWithInteger1(int number1)
        {
            Fraction result = new Fraction(number1);
            return result;
        }

        public Fraction FractionReduce(Fraction improperFraction)
        {
            int reducedNumerator = improperFraction.Numerator; 
            int reducedDenominator = improperFraction.Denominator;            
            int min = Math.Min(reducedNumerator, reducedDenominator);

            if (reducedNumerator % Denominator == 0)
            {
                return new Fraction(reducedNumerator / reducedDenominator);
            }
            else
            {                
                int diff = Math.Abs(reducedNumerator - reducedDenominator);
                int temp;

                while (min != diff)
                {
                    temp = Math.Min(min, diff);
                    diff = Math.Abs(diff - min);
                    min = temp;
                }                
            }

            reducedNumerator /= min; 
            reducedDenominator /= min;
            
            Fraction result = new Fraction(reducedNumerator, reducedDenominator);
            return result;
        }
    }
}