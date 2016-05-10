using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMaxElementInStack
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
                string[] line = Console.ReadLine().Split(' ');
                int[] intLine = Array.ConvertAll(line, Int32.Parse);
                int action = intLine[0];

                
                switch (action)
                {
                    case 1:
                        stack.Push(intLine[1]);
                        if (intLine[1] > maxElement)
                            maxElement = intLine[1];
                        break;
                    case 2:
                        int topAtStack = stack.Pop();
                        if (topAtStack == maxElement)
                        {
                            maxElement = MaxElementInStack(stack);
                        }
                        break;
                    case 3:
                        Console.WriteLine(maxElement);
                        break;
                    default:
                        Console.WriteLine("Incorrect value.");
                        break;
                }
            }
        }

        public static int MaxElementInStack(Stack<int> stack)
        {
            int maxElement = Int32.MinValue;
            if (stack.Count > 0)
            {
                maxElement = stack.Peek();
                foreach (int val in stack)
                {
                    if (val > maxElement)
                        maxElement = val;
                }
            }
            return maxElement;            
        }        
    }
}
