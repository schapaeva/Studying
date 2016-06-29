using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses2
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                if (IfBalanced(s))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        public static bool IfBalanced(string line)
        {
            char[] openParentheses = { '(', '{', '[' };
            char[] closeParentheses = { ')', '}', ']' };
            Stack<char> stack = new Stack<char>();
            bool balanced = true;

            foreach (char ch in line)
            {
                if (openParentheses.Contains(ch))
                    stack.Push(ch);
                else if (stack.Count > 0 && closeParentheses.Contains(ch) && ParenthesesComparer(stack.Peek(), ch))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            if (stack.Count == 0 && balanced)
                balanced = true;
            else
                balanced = false;
            return balanced;
        }

        public static bool ParenthesesComparer(char openParenthese, char closeParenthese)
        {
            return ((openParenthese == '[' && closeParenthese == ']') || (openParenthese == '{' && closeParenthese == '}') ||
                (openParenthese == '(' && closeParenthese == ')'));
        }
    }
}
