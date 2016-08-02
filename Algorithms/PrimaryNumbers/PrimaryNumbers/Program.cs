using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for which you want to print primary number: ");
            int n;
            bool result = Int32.TryParse(Console.ReadLine(), out n);
            if (result && ValidateInput(n))
            {
                PrintPrimaryNumbers(n);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadKey();
        }

        public static bool ValidateInput(int n)
        {
            if (n < 1)
                return false;
            return true;
        }

        public static void PrintPrimaryNumbers(int n)
        {
            for (int i = 2; i < n; i++)
            {
                bool ifPrimary = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        ifPrimary = false;
                        break;
                    }
                }
                if (ifPrimary)
                    Console.Write(i.ToString() + " ");
            }
        }
    }
}
