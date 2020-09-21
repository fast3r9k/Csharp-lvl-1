using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate void reverse();

    class Doubler
    {
        int value;
        int steps;
        int goal;
        public int Value { get { return this.value; } }      
        public int Steps { get { return this.steps; } }
        public int Goal { get { return this.goal; } }

        Random rand = new Random();

        Stack<reverse> operations = new Stack<reverse>();

        public Doubler()
        {
            this.value = 0;
            this.steps = 0;
            this.goal = 0;
        }

        public void Increment()
        {
            this.value++;
            this.steps++;
            operations.Push(new reverse(Decrement));
        }

        public void Decrement()
        {
            this.value--;
            this.steps--;
        }

        public void Double()
        {
            this.value *= 2;
            this.steps++;
            operations.Push(new reverse(DivisionbyTwo));
        }

        public  void DivisionbyTwo()
        {
            this.value /= 2;
            this.steps--;            
        }

        public void LastStep()
        {
            reverse reverseFunc;
            if(operations.Count != 0)
            {
                reverseFunc = operations.Pop();
                reverseFunc();
            }
            return;
        }

        public void Reset()
        {
            this.value = 1;
            this.steps = 0;
            operations.Clear();
        }

        public void GetGoal()
        {
            this.goal = rand.Next(2, 1000);
        }

        public bool Check()
        {
            return this.value == this.goal ? true : false;
        }
    }
}
