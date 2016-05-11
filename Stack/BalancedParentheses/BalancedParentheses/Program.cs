using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                CheckBalancedParentheses(Console.ReadLine().ToCharArray());
            }
        }

        public static bool CheckBalancedParentheses(char[] line)
        {
            char[] openBrackets = { '(', '[', '{' };
            char[] closeBrackets = { ')', ']', '}' };
            Stack<char> stack = new Stack<char>();
            bool balanced = true;

            foreach (char chr in line)
            {
                if (openBrackets.Contains(chr))
                    stack.Push(chr);
                else if (closeBrackets.Contains(chr))
                {
                    if (stack.Count > 0 && ParenthesesComparer(stack.Peek(), chr))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        balanced = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    balanced = false;
                    break;
                }
            }
            if (stack.Count == 0 && balanced)
                Console.WriteLine("YES");
            else
            {
                balanced = false;
                Console.WriteLine("NO");
            }
            return balanced;
        }

        public static bool ParenthesesComparer(char openParenthes, char closeParenthes)
        {
            if ((openParenthes == '{' && closeParenthes == '}') || (openParenthes == '[' && closeParenthes == ']')
                || (openParenthes == '(' && closeParenthes == ')'))
                return true;
            return false;
        }

    }
}
