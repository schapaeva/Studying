using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x and y: ");
            string userInput = Console.ReadLine();
            string[] inputArray = userInput.Split(' ');
            int x = Convert.ToInt32(inputArray[0]);
            int y = Convert.ToInt32(inputArray[1]);
            int hammingDistance = CalculateHammingDistance(x, y);
            Console.Write("\nHamming distance: {0}", hammingDistance);
            Console.ReadLine();
        }

        static int CalculateHammingDistance(int x, int y)
        {
            int z = x ^ y;
            int n = 0;
            while (z > 0)
            {
                z = z & (z - 1);
                ++n;
            }
            return n;
        }
    }
}
