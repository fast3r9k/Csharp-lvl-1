using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Randomiser
    {
        int value;
        int steps;

        public int Value { get { return this.value; } }
        public int Steps { get { return this.steps; } }

        public Randomiser(int max)
        {
            Start(max);
        }

        public void Start(int max)
        {
            Random r = new Random();
            this.value = r.Next(0, max);
        }

        public string Check(out bool check, int userAnswer)
        {
            if(userAnswer == this.value)
            {
                check = true;
                steps++;
                return $"Вы угадали число. Совершено попыток = {steps}";
            }    
            else if(userAnswer < this.value)
            {
                check = false;
                steps++;
                return $"Ваше число слишком маленькое";
            }
            else
            {
                check = false;
                steps++;
                return $"Ваше число слишком большое";
            }
        }
        public void Reset()
        {
            this.steps = 0;
        }
    }
}
