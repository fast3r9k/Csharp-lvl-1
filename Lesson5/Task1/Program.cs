using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) с использованием регулярных выражений.
//    Матвеев Никита
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 3;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("Проверка без регулярного выражения");
                if (CheckLogin(login))
                {
                    Console.WriteLine("true");                    
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный логин. Повторите попытку. Осталось попыток = {attempts}");
                }
                Console.WriteLine("Проверка с использованием регулярного выражения");
                if (CheckWithReg(login))
                {
                    Console.WriteLine("Reg true");
                    break;
                }
                else Console.WriteLine("Reg false");
            }
            while (attempts > 0);
            Console.ReadLine();
        }

        static bool CheckLogin(string login)
        {
            int length = login.Length;

            if (length >= 2 && length <= 10)
            {
                bool checkChar = true;
                char firstSymbol = login[0];
                if (Char.IsDigit(firstSymbol))
                {
                    Console.WriteLine("Первый символ не может быть цифрой");
                    checkChar = false;
                }
                for (int i = 0; i < login.Length; i++)
                {
                    char temp = login[i];
                    if (!(Char.IsDigit(temp) || CheckLatin(temp)))
                    {
                        checkChar = false;
                        break;
                    }
                }
                if (checkChar)
                    return true;
            }
            else Console.WriteLine("Логин должен содержать от 2 до 10 символов");
            return false;
        }

        static bool CheckLatin(char temp)
        {
            int num = temp;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }

        static bool CheckWithReg(string login)
        {
            string pattern = @"^[a-zA-Z][a-zA-Z0-9]{2,9}$";
            if (Regex.IsMatch(login, pattern))
                return true;
            return false;
        }
    }
}
