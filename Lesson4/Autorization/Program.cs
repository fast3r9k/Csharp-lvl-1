using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Условие
/*
    Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
    Матвеев Никита
*/
#endregion
namespace Autorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа проверки логина и пароля, считанных из файла.");

            check();
            Console.ReadLine();
        }

        static void check()
        {
            string[] filename = { "data.txt",  "trueData.txt", "tryData.txt"};
            Account account;
            account.login = "";
            account.password = "";
            int counter = 3;
            for (int i = 0; i < filename.Length; i++)
            {
                do
                {
                    account.LoadFromTxt(filename[i]);
                    if (account.login == "root" && account.password == "GeekBrains")
                    {
                        Console.WriteLine("Данные введеы верно");
                        Console.WriteLine("Авторизация успешна!");
                        i = filename.Length;
                        break;
                    }
                    else
                    {
                        counter -= 1;
                        Console.WriteLine($"Неправильный логин или пароль. Осталось попыток = {counter}");
                        i++;
                    }
                }
                while (counter > 0);
                if (counter == 0)
                {
                    Console.WriteLine("У вас закончились попытки. Попробуйте позже. Нажмите любую клавишу для выхода");
                }
            }

        }
    }
}
