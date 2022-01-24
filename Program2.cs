using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Fraction
    {
        public int Numerator;
        public int Denomenator;
        public Fraction(int numerator, int denomenator)
        {
            Numerator = numerator;
            Denomenator = denomenator;
        }
        public Fraction(int numerator)
        {
            Numerator = numerator;
            Denomenator = 1;
        }
        private Fraction CheckFraction(Fraction resultFraction)
        {
            if (resultFraction.Numerator == resultFraction.Denomenator)
            {
                resultFraction.Numerator = 1;
                resultFraction.Denomenator = 1;
            }
            else
            {
                for (int i = 1; i <= resultFraction.Numerator; i++)
                {
                    if (resultFraction.Numerator % i == 0 && resultFraction.Denomenator % i == 0)
                    {
                        resultFraction.Numerator = resultFraction.Numerator / i;
                        resultFraction.Denomenator = resultFraction.Denomenator / i;
                    }
                }
            }
            return resultFraction;
        }
        public void Print()
        {
            Console.WriteLine($"{Numerator}/{Denomenator}");
        }
        public Fraction Sum(Fraction otherFraction)
        {
            int commonDenomenator = Denomenator * otherFraction.Denomenator;
            int resultNumerator = Numerator * otherFraction.Denomenator + otherFraction.Numerator * Denomenator;
            Fraction result = new Fraction(resultNumerator, commonDenomenator);
            return CheckFraction(result);
        }
        public Fraction Difference(Fraction otherFraction)
        {
            int commonDenomenator = Denomenator * otherFraction.Denomenator;
            int resultNumerator = Numerator * otherFraction.Denomenator - otherFraction.Numerator * Denomenator;
            Fraction result = new Fraction(resultNumerator, commonDenomenator);
            return CheckFraction(result);
        }
        public Fraction Multiply(Fraction otherFraction)
        {
            Fraction result = new Fraction(Numerator * otherFraction.Numerator, Denomenator * otherFraction.Denomenator);
            return CheckFraction(result);
        }
        public Fraction Divide(Fraction otherFraction)
        {
            Fraction result = new Fraction(Numerator * otherFraction.Denomenator, Denomenator * otherFraction.Numerator);
            return CheckFraction(result);
        }
        public Fraction Sum(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            return Sum(otherFraction);
        }
        public Fraction Difference(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            return Difference(otherFraction);
        }
        public Fraction Multiply(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            return Multiply(otherFraction);
        }
        public Fraction Divide(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            return Divide(otherFraction);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 2);
            fraction1.Print();
            Fraction fraction2 = new Fraction(1, 3);
            fraction2.Print();
            Console.WriteLine("--------------------------");

            Fraction result = fraction1.Sum(fraction2);
            result.Print();

            result = fraction1.Difference(fraction2);
            result.Print();

            result = fraction1.Multiply(fraction2);
            result.Print();

            result = fraction1.Divide(fraction2);
            result.Print();

            Console.WriteLine("--------------------------");

            result = fraction1.Sum(1);
            result.Print();

            result = fraction1.Difference(1);
            result.Print();

            result = fraction1.Multiply(2);
            result.Print();

            result = fraction1.Divide(2);
            result.Print();
        }
    }
}