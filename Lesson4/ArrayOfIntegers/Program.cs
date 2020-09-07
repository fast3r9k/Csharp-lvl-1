using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Условие
/*
 * Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
 * Матвеев Никита
 */
#endregion
namespace ArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arrayLength = 20;
            int[] array = new int[arrayLength];
            Random random = new Random();
            Console.WriteLine("Сформирован массив:");
            for (int i=0;i<array.Length;i++)
            {
                array[i] = random.Next(-10000, 10001);
                Console.WriteLine($"array{i} = {array[i]}, ");
            }
            Console.WriteLine($"\nКоличество пар, делимых на 3 = {GetNumberOfPairs(array, arrayLength)}");

            Console.ReadLine();
        }

        static int GetNumberOfPairs(int[] array, int length)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }
    }
}
