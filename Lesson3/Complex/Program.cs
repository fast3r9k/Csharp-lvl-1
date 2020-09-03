using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    /*
     1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
        б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
    Матвеев Никита
     */

    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(Re: 10, Im: 23);
            Complex z2 = new Complex(Re: 15, Im: -7);
            Complex z3 = z1 + z2;
            Complex z4 = z1 - z2;
            C_Complex x1 = new C_Complex(Re: 13, Im: 3);
            x1.B = 5;
            C_Complex x2 = new C_Complex(Re: -7, Im: 11);
            C_Complex x3 = x1 * x2;
            C_Complex x4 = x1 - x2;
            Console.WriteLine($"Результат сложения = {z3}\nРезультат вычитания = {z4}");
            Console.WriteLine($"Резульятат умножения(с использованием класса) = {x3}\nРезульятат вычитания (с использованием класса) = {x4}");
            Console.ReadKey();
        }
    }
}
