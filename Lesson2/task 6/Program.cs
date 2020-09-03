using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    /* а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
     набрать вес или все в норме;
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


    Матвеев Никита
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вес человека в кг: ");
            double mass = double.Parse(Console.ReadLine());
            Console.Write("Введите рост человека в см: ");
            double heigth = double.Parse(Console.ReadLine());
            heigth /= 100;
            double BMI = mass / (heigth * heigth);
            Console.WriteLine("Индекс массы тела: {0:0.##}", BMI);
            Console.WriteLine(CheckBmi(BMI, heigth));


            Console.ReadKey();
        }

        static string CheckBmi(double bmi, double heigth)
        {
            string result = null;
            if (bmi >= 18.5 && bmi <= 24.99)
            {
                result = "Всё в норме!";
            }
            else if (bmi < 18.5)
            {
                double recommendation = (18.5 - bmi) * Math.Pow(heigth, 2);
                result = String.Format("Вам необходимо набрать {0:0.00} кг", recommendation);
            }
            else if (bmi > 24.99)
            {
                double recommendation = (bmi - 24.99) * Math.Pow(heigth,2);
                result = String.Format("Вам необходимо сбросить {0:0.00} кг", recommendation);
            }

            return result;
        }
    }
    
}
