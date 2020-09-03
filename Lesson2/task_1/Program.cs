using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    /*Написать метод, возвращающий минимальное из трех чисел.
    Матвеев Никита
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = GetInt();

            Console.Write("Введите второе число: ");
            int b = GetInt();

            Console.Write("Введите третье число: ");
            int c = GetInt();

            Console.WriteLine($"Минимальное число: {MinNumber(a, b, c)}");

            Console.ReadLine();
        }

        static int GetInt() 
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста повторите ввод: ");
                else return x;
        }

        static int MinNumber(int a, int b, int c)
        {
            if (a >= b)
            {
                if (b <= c)
                    return c;
                else return b;
            }
            else
            {
                if (a >= c)
                    return c;
                else return a;
            }
        }
    }
}
