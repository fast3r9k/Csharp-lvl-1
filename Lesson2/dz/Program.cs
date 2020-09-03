using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    /*
     a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.


        Матвеев Никита
    */
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            Values(a, b);
            Console.WriteLine($"\nСумма чисел в диапазоне [a,b] = {Summ(a, b)}");
            Console.ReadLine();
        }

        public static void Values(int a, int b)
        {
            int s = a;

            if (a <= b)
            {
                a++;
                Console.Write("{0} ", s);
                Values(a, b);
            }
        }

        public static int Summ(int a, int b)
        {
            return (a == b) ? b : (a + Summ(a + 1, b));
        }
    }
}
