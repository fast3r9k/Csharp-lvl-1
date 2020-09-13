using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
    //Матвеев Никита

namespace Task1
{

    public delegate double Func(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции a*x^2: ");
            Table(new Func(MyFunc), -3, 12,2);
            Console.WriteLine("Таблица функции a*sin(x): ");
            Table(new Func(MySin), -3, 60, 30);
            Console.ReadLine();
        }

        public static void Table(Func F, double a, double b, double x)
        {
            Console.WriteLine("----- A----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

    }
}
