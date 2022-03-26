using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fraction
    {
       readonly long numerator;
       readonly long denominator;

        public Fraction(long first, long second)
        {
            if(numerator <= 0 || denominator<=0)
            {
              throw new ArgumentException("exception");
            }
            
            numerator = first;
            denominator = second;
        }

        public long CreateFraction()
        {
            return numerator/denominator;
        }

        public override string ToString()
        {
            return "${numerator}/{denominator}";
        }

        // implement add fraction method without przeciazenie operatora 

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
        }

    

       
    }
}
