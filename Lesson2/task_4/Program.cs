using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    /*Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь,
     если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: 
     пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
     С помощью цикла do while ограничить ввод пароля тремя попытками.

    Матвеев Никита
*/
    class Program
    {
        static void Main(string[] args)
        {
            check();
            Console.ReadKey();
        }

        static void check()
        {
            string login = "root";
            string password = "GeekBrains";
            int counter = 3;
            do
            {
                Console.WriteLine("Введите логин: ");
                string userLogin = Console.ReadLine().ToLower();
                Console.WriteLine("Введите пароль: ");
                string userPassword = Console.ReadLine();

                if (userLogin == login && userPassword == password)
                {
                    Console.WriteLine("Данные введеы верно");
                    Console.WriteLine("Авторизация успешна!");

                    break;
                }
                else
                {
                    counter -= 1;
                    Console.WriteLine($"Вы ввели неправильный логин или пароль. Осталось попыток = {counter}");
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
