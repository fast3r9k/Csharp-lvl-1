using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    struct Complex
    {
        public double a;
        public double b;

        public Complex (double Re, double Im)
        {
            a = Re;
            b = Im;
        }
        static public Complex operator +(Complex x, Complex y)
        {
            return new Complex(
                Re: x.a + y.a,
                Im: x.b + y.b);
        }

        static public Complex operator -(Complex x, Complex y)
        {
            return new Complex(
               Re: x.a - y.a,
               Im: x.b - y.b);
        }

        static public Complex operator *(Complex x, Complex y)
        {
            return new Complex(
                Re: x.a * y.a - x.b * y.b,
                Im: x.a * y.b + y.a * x.b);
        }
        public override string ToString()
        {
            if (b == 0) return $"{a}";
            else if (a == 0) return $"{b}";
            else return (b < 0) ? $"{a} - {-b}i" : $"{a} + {b}i";

        }
    }
}
