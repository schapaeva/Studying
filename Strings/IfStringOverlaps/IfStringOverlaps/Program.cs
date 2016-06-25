using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStringOverlaps
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                if (IfSubstring(a, b))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
        public static bool IfSubstring(string a, string b)
        {
            HashSet<char> aHash = new HashSet<char>(a.ToCharArray());
            HashSet<char> bHash = new HashSet<char>(b.ToCharArray());
            if (aHash.Overlaps(bHash))
                return true;
            else
                return false;
        }
    }
}
