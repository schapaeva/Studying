using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesseAndCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(temp[0]);
            int k = Convert.ToInt32(temp[1]);
            int iterations = 0;

            temp = Console.ReadLine().Split(' ');
            int[] cookies = Array.ConvertAll(temp, Int32.Parse);
            Queue<int> queue = new Queue<int>(cookies);
            queue.OrderBy(q => q);

            if (queue.Count > 0) //initial queue check
            {
                while (queue.Peek() < k)
                {
                    if (queue.Count > 0)
                    {
                        int currentCookie = queue.Dequeue();
                        if (queue.Count > 0)
                        {
                            int nextCookie = queue.Dequeue();
                            queue.Enqueue(1 * currentCookie + 2 * nextCookie);
                            iterations++;
                            queue.OrderBy(q => q);
                        }
                        else
                            Console.WriteLine("-1");
                    }
                    else
                        Console.WriteLine("-1");
                }
                Console.WriteLine(iterations.ToString());
            }
            else
            {
                Console.WriteLine("-1");
            }


        }

    }
}
