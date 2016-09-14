using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithMin
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackWithMin stack = new StackWithMin();
            stack.Push(5);
            stack.Push(6);
            stack.Push(1);
            stack.Push(7);
            Console.WriteLine(stack.GetMin().ToString());
            stack.Pop();
            Console.WriteLine(stack.GetMin().ToString());
            stack.Pop();
            Console.WriteLine(stack.GetMin().ToString());
            Console.ReadKey();
        }
    }

    public class StackWithMin : Stack<int>
    {
        Stack<int> minStack;
        
        //constructor
        public StackWithMin(){
            minStack = new Stack<int>();
        }

        public void Push(int value)
        {
            if (value <= GetMin())
                minStack.Push(value);
            base.Push(value);
        }

        public int Pop()
        {
            int value = base.Pop();
            if (value == GetMin())
                minStack.Pop();
            return value;
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
                return Int32.MaxValue;
            else
                return minStack.Peek();
        }
    }
}
