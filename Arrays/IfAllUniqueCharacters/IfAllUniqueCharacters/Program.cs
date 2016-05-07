using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfAllUniqueCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            Console.WriteLine(IfUniqueCharacters(userInput).ToString());
            Console.ReadLine();
            

        }

        public static bool IfUniqueCharacters(string input)
        {
            if (input.Length > 128)
                return false;
            else
            {
                bool[] characters = new bool[128];
                for (int i=0; i < input.Length; i++)
                {
                    int val = (int)input[i];
                    if (characters[val])
                        return false;
                    else
                        characters[val] = true;
                }
                return true;
            }
        }
    }
}
