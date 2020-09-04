using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions
{
    /*
 * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
 * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
 * Написать программу, демонстрирующую все разработанные элементы класса. 
 * Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
 * 
 * Матвеев Никита
 */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числитель первой дроби: ");
            int n1 = GetInt();
            Console.Write("Введите знаменатель первой дроби: ");
            int d1 = GetInt();
            Fraction f1 = new Fraction(n1, d1);
            Console.Write("Введите числитель второй дроби: ");
            int n2 = GetInt();
            Console.Write("Введите знаменатель второй дроби: ");
            int d2 = GetInt();
            Fraction f2 = new Fraction(n2, d2);
            Fraction f3 = f1 + f2;
            Fraction f4 = f1 - f2;
            Fraction f5 = f1 * f2;
            Fraction f6 = f1 / f2;
            Console.WriteLine($"Результат сложения = {f3}\nРезультат вычитания = {f4}\nРезультат умножения = {f5}\nРезультат деления = {f6}");
            Console.ReadLine();

        }

        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Требуется числовое значение.\nПовторите ввод: ");
                else return x;
        }
    }
}
