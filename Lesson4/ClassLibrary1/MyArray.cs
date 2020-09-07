using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyArray
    {
        int[] a;
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        public int Sum()
        {

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            return sum;

        }

        public void Inverse()
        {


            for (int i = 0; i < a.Length; i++)
                a[i] = a[i] * -1;

        }

        public int Min()
        {

            int min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] < min) min = a[i];
            return min;

        }

        public int Multi
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) count++;
                return count;
            }
        }

        public void Print()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }


        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }

        public MyArray(int n, int firstElement, int step)
        {
            a = new int[n];
            a[0] = firstElement;
            for (int i = 1; i < n; i++)
                a[i] = a[i - 1] + step;
        }

        public MyArray(string filename)
        {

            if (File.Exists(filename))
            {

                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];

                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else throw new FileNotFoundException("Неверный путь");


        }

        public void saveIntoFile(string filename)
        {
            string[] a_string = new string[a.Length];
            for (int i = 0; i < a_string.Length; i++)
                a_string[i] = Convert.ToString(a[i]);

            File.WriteAllLines(filename, a_string);
        }
        public void loadFromFile(string filename)
        {

            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else throw new Exception("Не удалось загрузить файл");
        }
    }
}
