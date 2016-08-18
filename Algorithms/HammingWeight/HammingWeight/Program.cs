using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingWeight
{
    public class Program
    {
        static void Main(string[] args)
        {
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(HammingWeight(n).ToString());
            Console.ReadKey();
        }

        public static int HammingWeight(uint n)
        {
            string binary = Convert.ToString(n, 2);
            if (binary.Length == 0) return 0;

            int count = 0;
            foreach (char ch in binary)
            {
                int num = int.Parse(ch.ToString());
                if (num != 0) count++;
            }
            return count;
        }
    }
}
