using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
