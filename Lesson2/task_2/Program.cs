using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    /*
        Написать метод подсчета количества цифр числа.


    Матвеев Никита
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            string number = CheckValidation();

            Console.WriteLine($"Количество цифр: {NumberLength(number)}. Нажмите любую клавишу для выхода");

            Console.ReadKey();
        }
        static int NumberLength(string number)
        {
            return number.Length;
        }

        static string CheckValidation()
        {
            string number = "";
            bool checkNotAnumber;
            do
            {
                checkNotAnumber = false;
                number = Console.ReadLine();
                for (int i = 0; i < number.Length; i++)
                {
                    if (!Char.IsNumber(number, i))
                    {
                        checkNotAnumber = true;
                        Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста повторите ввод: ");
                        break;
                    }
                }
            } while (checkNotAnumber);
            return number;
        }
    }
}
