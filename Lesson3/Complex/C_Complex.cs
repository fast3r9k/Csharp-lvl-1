using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    internal class C_Complex
    {
        private double a, b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double A
        {
            get { return a; }
             set { a = value; }
        }
        public C_Complex() { }
        public C_Complex(double Re, double Im)
        {
            a = Re;
            b = Im;
        }
        static public C_Complex operator -(C_Complex x, C_Complex y)
        {
            return new C_Complex(
               Re: x.a - y.a,
               Im: x.b - y.b);
        }
        static public C_Complex operator *(C_Complex x, C_Complex y)
        {
            return new C_Complex(
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
