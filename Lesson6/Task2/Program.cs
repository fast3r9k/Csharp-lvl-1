using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
//б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
//в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
//возвращает минимум через параметр.
//    Матвеев Никита

namespace Task2
{
    public delegate double Fun(double x);
    class Program
    {
        
        static void Main(string[] args)
        {
            int myFunc;
            double start = 0;
            double end = 0;
            List<Fun> functions = new List<Fun> { new Fun(SecondDegreeFunc), new Fun(ThirdDegreeFunc), new Fun(SqrtFunc)};
            Console.WriteLine("Все функции:");
            Console.WriteLine("1) f(x)=y^2\n2) f(x)=y^3\n3) f(x) = y ^ 1 / 2");
            Console.WriteLine("Введите номер нужной функции");
            myFunc = GetInt(functions.Count);
            Console.WriteLine("Задайте отрезок для нахождения минимума в формате 'х1 х2':");
            Interval(out start, out end);
            Console.WriteLine("Задайте величинау шага");
            double step = double.Parse(Console.ReadLine());

            SaveFunc("data.bin", start, end, step, functions[myFunc - 1]);
            double min = double.MaxValue;
            Console.WriteLine("Получены значения функции: ");
            Result(start, end, step, Load("data.bin", out min));
            Console.WriteLine("Минимальное значение функции = {0:0.00}", min);
            Console.ReadKey();


        }

        public static void SaveFunc(string fileName, double start, double end, double step, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            while (start <= end)
            {
                bw.Write(F(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double temp;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                temp = bw.ReadDouble();
                array[i] = temp;
                if (temp < min) min = temp;
            }
            bw.Close();
            fs.Close();
            return array;
        }

        static double SecondDegreeFunc(double x)
        {
            return x*x;
        }

        static double ThirdDegreeFunc(double x)
        {
            return x * x * x;
        }

        static double SqrtFunc(double x)
        {
            return Math.Sqrt(x);
        }

        static int GetInt(int max)
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max || x == 0)
                    Console.Write($"Введите числовое значение от 1 до {max}.\nПовторите ввод: ");
                else return x;
        }

        static void Interval(out double start, out double end)
        {
            string[] interval = Console.ReadLine().Split(' ');
            start = double.Parse(interval[0]);
            end = double.Parse(interval[1]);
        }

        static void Result(double start, double end, double step, double[] values)
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }
    }
}
