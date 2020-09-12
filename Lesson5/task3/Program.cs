using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = WriteString();
            string s2 = WriteString();
            CompareStrings(s1, s2);
            Console.WriteLine("Сравнение другим методом:");
            s1 = WriteString();
            s2 = WriteString();
            MyCompare(s1, s2);
            Console.ReadLine();
        }

        private static void MyCompare(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            string newstring1 = s1[0].ToString();
            string newstring2 = s2[0].ToString();

            for (int i = 1; i < s1.Length; i++)
                putCharIntoStr(ref newstring1, s1[i]);

            for (int i = 1; i < s2.Length; i++)
                putCharIntoStr(ref newstring2, s2[i]);

            if (newstring1.Equals(newstring2))
                Console.WriteLine("Стройки совпадают");
            else Console.WriteLine("Строки не совпадают");
        }

        private static void putCharIntoStr(ref string s, char ch)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > ch)
                {
                    s = s.Insert(i, ch.ToString());
                    break;
                }
                else
                    if (i == s.Length - 1)
                {
                    s += ch.ToString();
                    break;
                }
            }
        }

        private static void CompareStrings(string s1, string s2)
        {
            if (s1.Select(Char.ToLower).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToLower).OrderBy(x => x)))
                Console.WriteLine("Стройки совпадают");
            else Console.WriteLine("Строки не совпадают");
        }

        private static string WriteString()
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            return s;
        }
    }
}
