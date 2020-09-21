using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Условие
/*
 Реализуйте задачу 1 в виде статического класса StaticClass;
 а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
 в)** Добавьте обработку ситуации отсутствия файла на диске.
 * Матвеев Никита
 */
#endregion


namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "TxtArray.txt";
            string badFilename = "asdasdasdasd.txt";
            int[] myArray = Static.FillArray();
            Console.WriteLine($"\nКоличество пар, делимых на 3 = {Static.GetNumberOfPairs(myArray)}\n");
            int[] ArrayOfIntegers = Static.LoadFromTxt(filename);
            Console.WriteLine("Массив из файла: ");
            for (int i = 0; i < ArrayOfIntegers.Length; i++)
            {
                Console.Write($"{ArrayOfIntegers[i]}, ");
            }
            Console.WriteLine();
            try
            {
                int[] exception = Static.LoadFromTxt(badFilename);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            Console.ReadLine();
        }
    }
}
