using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithoutPlus
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(5, 6));
            Console.ReadKey();
        }

        public static int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int carry = (a & b); //CARRY is AND of two bits
                a = a ^ b; //SUM of two bits is A XOR B
                b = carry << 1; //shifts carry to 1 bit to calculate sum
            }
            return a;
        }
    }
}
