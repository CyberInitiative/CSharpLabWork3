using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork3
{
    public class Fraction
    {
        int Numerator;
        int Denominator;
        public Fraction() { Numerator = Denominator = 1; }
        public Fraction(int n, int d)
        {
            this.Numerator = n;
            this.Denominator = d;
        }

        public void ShowTheFractionMethod()
        {
            Console.WriteLine("Дробь в обыкновенном виде:" + "\n");
            Console.WriteLine("\0" + Numerator);
            Console.WriteLine("\0" + "---");
            Console.WriteLine("\0" + Denominator);
            Console.WriteLine("\n");
            Console.WriteLine("Дробь в десятичном виде:" + "\n");
            Console.WriteLine( "\0" + Math.Round(((double)Numerator / (double)Denominator) , 5));
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction(1 , 1);
            result.Numerator = (f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator);
            result.Denominator = f1.Denominator * f2.Denominator; 
            return result;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction(1, 1);
            result.Numerator = (f1.Numerator * f2.Denominator - f1.Denominator * f2.Numerator);
            result.Denominator = f1.Denominator * f2.Denominator;
            return result;
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        { 
            Fraction result = new Fraction(1, 1);
            result.Numerator = f1.Numerator * f2.Numerator;
            result.Denominator = f1.Denominator * f2.Denominator;
            return result;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction(1, 1);
            result.Numerator = f1.Numerator / f2.Numerator;
            result.Denominator = f1.Denominator / f2.Denominator;
            return result;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            Fraction result1 = new Fraction();
            Fraction result2 = new Fraction();
            result1.Denominator = f1.Denominator * f2.Denominator;
            result2.Denominator = f1.Denominator * f2.Denominator;
            result1.Numerator = (f1.Numerator * f2.Denominator );
            result2.Numerator = (f1.Denominator * f2.Numerator );
            if (result1.Numerator > result2.Numerator)
                return true;
            else
                return false;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            Fraction result1 = new Fraction();
            Fraction result2 = new Fraction();
            result1.Denominator = f1.Denominator * f2.Denominator;
            result2.Denominator = f1.Denominator * f2.Denominator;
            result1.Numerator = (f1.Numerator * f2.Denominator);
            result2.Numerator = (f1.Denominator * f2.Numerator);
            if (result1.Numerator < result2.Numerator)
                return true;
            else
                return false;
        }
    }
}
