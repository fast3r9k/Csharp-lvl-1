using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class Message
    {
        static public string text;
        static public string filename = "TEXT.txt";

        static Message()
        {            
            LoadFromTxt(filename);
        }
        
        static public void GetWordsByLength(int length)
        {
            Console.WriteLine($"Все слова короче {length} символов");
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '!', '?' });
            foreach (var word in words)
            {
                if ( word != "")
                {
                    if (word.Length <= length)
                        Console.WriteLine(word);
                }
            }
        }

        static public void DeleteWordByEnd(string symbol)
        {

            Console.WriteLine($"\nРезультат после удаления слов, заканчивающихся на {symbol} :");
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '!', '?' });
            for (int i = 0; i < words.Length;i++)
            {
                if (words[i].EndsWith(symbol.ToLower()))
                {
                    words[i] = null;
                }
                if (words[i] != null)
                    Console.Write($"{words[i]} ");
            }         
        }

        static public string TheLongestWord()
        {            
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '!', '?' });
            string temp = words[0];
            int max = 0;
            foreach(var word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    temp = word;
                }
            }
            
            return temp;
        }

        static public StringBuilder GetLongStringBuild()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.TheLongestWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word + " ");
                }
            }
            return result;
        }

        static public string LoadFromTxt(string filename)
        {
            filename = @"..\..\" + filename;
            using (StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                text = sr.ReadLine();
                sr.Close();
                return text;
            }
        }
    }
}
