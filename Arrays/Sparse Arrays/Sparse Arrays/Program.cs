using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparse_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputNArr = new string[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                inputNArr[i] = Console.ReadLine();
            }

            int q = Convert.ToInt32(Console.ReadLine());
            string[] inputQArr = new string[q];

            for (int i = 0; i < q; i++)
            {
                inputQArr[i] = Console.ReadLine();
            }

            foreach(string qLine in inputQArr)
            {
                foreach(string nLine in inputNArr)
                {
                    if (nLine == qLine)
                        count++;
                }
                Console.WriteLine(count.ToString());
                count = 0;
            }            

            Console.ReadLine();
        }
    }
}
