using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNullTermStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int endIndex = userInput.IndexOf("\0");
            char[] converted = userInput.ToCharArray();

            for (int i = 0; i < endIndex; i++)
            {
                
            }

        }
    }
}
