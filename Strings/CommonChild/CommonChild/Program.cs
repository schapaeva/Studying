using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonChild
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            //HRARY | SALLY
            //H:{0} A:{2} R:{1,3} Y:{4} || S:{0} A{1} L{2,3} Y{4}
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(CommonChild(a, b).Length.ToString());
        }

        public static string CommonChild(string a, string b)
        {
            Dictionary<char, List<int>> aDict = PopulateDictionary(a);
            Dictionary<char, List<int>> bDict = PopulateDictionary(b);
            string child = "";
            //OUDFRMYMAW -> FMYMAW -> 
            //AWHYFCCMQX -> AWMYFM ->  
            foreach (KeyValuePair<char, List<int>> aPair in aDict)
            {
                if (!bDict.ContainsKey(aPair.Key))
                {
                    aDict.Remove(aPair.Key);
                    bDict.Remove(aPair.Key);
                }
            }
            return child;
        }

        public static Dictionary<char, List<int>> PopulateDictionary(string input)
        {
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], new List<int>());
                    dict[input[i]].Add(i);
                }
                else
                    dict[input[i]].Add(i);
            }
            return dict;
        }
    }
}
