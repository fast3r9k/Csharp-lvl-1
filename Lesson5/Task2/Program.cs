﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать класс Message, содержащий следующие статические методы для обработки
//текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//Продемонстрируйте работу программы на текстовом файле с вашей программой.
//    Матвеев Никита

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Message.GetWordsByLength(7);
            Message.DeleteWordByEnd("и");
            Console.WriteLine($"\nСамое длинное слово - { Message.TheLongestWord()}");
            Console.WriteLine($"{Message.GetLongStringBuild()}");
            Console.ReadLine();
        }
    }
}
