using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return Numerator; }
            set { Numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
                {
                    denominator = value;
                }
            }
        }        


        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.Denominator = denominator;
        }
        static public Fraction operator +(Fraction f1, Fraction f2)
        {
            int df = f1.denominator;
            int nf = f1.numerator + f2.numerator;
            if (f1.denominator != f2.denominator)
            {
                df *= f2.denominator;
                nf = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            }
            return new Fraction(nf, df);
        }
        static public Fraction operator -(Fraction f1, Fraction f2)
        {
            int df = f1.denominator;
            int nf = f1.numerator - f2.numerator;
            if (f1.denominator != f2.denominator)
            {
                df *= f2.denominator;
                nf = f1.numerator * f2.denominator - f2.numerator * f1.denominator;

            }
            return new Fraction(nf, df);
        }

        static public Fraction operator *(Fraction f1, Fraction f2)
        {

            return new Fraction(f1.numerator * f2.numerator, f1.denominator * f2.denominator);
        }

        static public Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2.denominator == 0) throw new DivideByZeroException("Деление на 0");
            else return new Fraction((f1.numerator * f2.denominator) , (f1.denominator*f2.numerator));
        }
        public override string ToString()
        {
            return (numerator <0 && denominator<0)?$"{-numerator} / {-denominator}": $"{numerator} / {denominator}";

        }

    }
}
