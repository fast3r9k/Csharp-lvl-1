using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

#region Условие
/*
а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  
метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 

 * Матвеев Никита
 */
#endregion

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = GetInt();
            Console.Write("Введите первый элемент массива: ");
            int firstElement = GetInt();
            Console.Write("Введите шаг для добавления последующих элементов: ");
            int step = GetInt();

            MyArray a = new MyArray(size, firstElement, step);

            Console.WriteLine($"\nСоздан массив:");
            a.Print();

            Console.WriteLine($"Сумма элементов массива: {a.Sum()}");

            a.Inverse();

            Console.WriteLine($"Массив с изменёнными знаками: \n");
            a.Print();

            Console.Write("Введите число, на которое будут умножены элементы массива: ");

            a.Multi = GetInt();

            Console.WriteLine($"Массив, умноженный на число: \n");
            a.Print();

            Console.WriteLine($"Максимальный элемент массива:  { a.Max}");

            Console.WriteLine($"Количество максимальных элементов массива: { a.MaxCount}");

            string fileName = "array.txt";
            MyArray b = new MyArray(fileName);
            //string fileName2 = "anotherArray.txt";
            Console.WriteLine("\nЗагрузим массив из файла");           

            Console.WriteLine($"Загружен следующий массив: \n");
            b.Print();

            string saveName = "SavedArray.txt";
            Console.WriteLine($"\nСохраним массив в файл { saveName}  при помощи метода.");

            b.saveIntoFile(saveName);

            MyArray myArray2 = new MyArray(saveName);

            Console.WriteLine($"Проверим содержимое файла, загрузив из него новый массив: \n");
            myArray2.Print();

            Console.ReadLine();

        }

        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Требуется числовое значение).\nПовторите ввод: ");
                else return x;
        }

    }
}
