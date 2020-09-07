using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static public class Static
    {
        static public int GetNumberOfPairs(int[] array)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }
        static public int[] FillArray()
        {
            const int arrayLength = 20;
            int[] array = new int[arrayLength];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10000, 10001);
                Console.Write($"{array[i]}, ");
            }
            return array;
        }
        static public int[] LoadFromTxt(string filename)
        {
           
                filename = @"..\..\" + filename;
                string text = File.ReadAllText(filename);

                int[] intArr = new int[] { };

                intArr = Array.ConvertAll(text.Split(), int.Parse);
                return intArr;

        }
    }
}
