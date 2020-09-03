using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbersAndException
{
    /*
     а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
     Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
     б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
     При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
     Матвеев Никита
 */
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int summ = 0;
            Console.WriteLine("Введите Ваши числа. Для завершения введите 0");
            while (true)
            {
                int result = CheckException();
                if (result == 0)
                {
                    break;
                }
                else if (result > 0 && result % 2 == 1)
                    temp = result;
                    summ += temp;
            }
            Console.WriteLine($"Сумма нечетных положительных чисел = {summ}");
            Console.ReadLine();
        }        
        static int CheckException()
        {
            int result = 0;
            bool Ex;
            do
            {
                Ex = int.TryParse(Console.ReadLine(), out result);
                if (Ex == false)
                {
                    Console.WriteLine("Вводите только числовые занчения!");
                }
                else if (result == 0)
                    break;
                Ex = true;
            }
            while (Ex);
            return result;

        }

        
    }
}
