using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(5, 32);
            Fraction f2 = new Fraction(12, 17);
            Fraction f3 = new Fraction(5, 25);
            Fraction f4 = new Fraction(10, 25);
            Fraction f1plusf2;  //дробь 1 - дробь 2
            f1plusf2 = f1 + f2;
            Fraction f3minusf1; //дробь 3 - дробь 1
            f3minusf1 = f3 - f2;

            Fraction f4plusf2;  //дробь 4 + дробь 2
            f4plusf2 = f4 + f2;
            Fraction f1minusf3; //дробь 1 - дробь 3
            f1minusf3 = f1 - f3;

            Fraction multfraction;
            multfraction = f1plusf2 * f3minusf1;
            Fraction divfraction;
            divfraction = f4plusf2 / f1minusf3;

            if (multfraction > divfraction)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.WriteLine("\n");
            if (f1 < f2)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");


            // multfraction.ShowTheFractionMethod();

            f1plusf2.ShowTheFractionMethod();
            Console.ReadKey();
        }
    }
}
