using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] sArray = Console.ReadLine().Split(' ');
            var sList = new List<string>();

            foreach(string s in sArray)
            {
                if (!sList.Contains(s))
                    sList.Add(s);
            }

            var sNew = sList.ToArray();
            PrintArray(sNew);
            Console.ReadKey();
        }

        public static void PrintArray(object[] array)
        {
            foreach (object obj in array)
            {
                Console.Write(obj.ToString() + " ");
            }
        }
    }
}
