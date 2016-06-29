using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExamples
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int maxElement = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                int[] line = Array.ConvertAll(tmp, Int32.Parse);
                int action = line[0];                

                switch (action)
                {
                    case 1:
                        stack.Push(line[1]);
                        maxElement = Math.Max(maxElement, line[1]);
                        break;
                    case 2:
                        int topStack = stack.Pop();
                        if (topStack == maxElement)
                            maxElement = MaxElementInStack(stack);
                        break;
                    case 3:
                        Console.WriteLine(maxElement.ToString());
                        break;
                    default:
                        Console.WriteLine("Incorrect Value.");
                        break;
                }

            }
        }
        public static int MaxElementInStack(Stack<int> stack)
        {
            int maxElement = Int32.MinValue;
            if (stack.Count > 0)
            {
                foreach (int val in stack)
                {
                    maxElement = Math.Max(maxElement, val);
                }
            }
            else
                throw new ArgumentException("Stack is empty.");
            return maxElement;
        }
    }
}
