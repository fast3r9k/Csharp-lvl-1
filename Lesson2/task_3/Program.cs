using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    /*С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

    Матвеев Никита
*/
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int oddNumbers = 0;
            while (true)
            {
                int number = GetInt();
                if (number == 0)               
                    break;
                else if (number > 0 && number % 2 == 1)
                {
                    oddNumbers++;
                }
            }

            Console.WriteLine("Количество нечетных чисел: " + oddNumbers);

            Console.ReadLine();
        }

        static int GetInt() 
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (введите чисо).\nПожалуйста, повторите ввод: ");
                else return x;
        }
    }
}
