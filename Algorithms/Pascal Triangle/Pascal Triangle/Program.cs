using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pascal_Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<List<int>> tr = CreatePascalTriangle(n);
            foreach(var item in tr)
            {
                PrintList(item);
            }
            Console.ReadKey();
        }
        public static List<List<int>> CreatePascalTriangle(int n)
        {
            List<List<int>> tr = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                List<int> row = new List<int>();
                row.Add(1);

                for (int j = 1; j < i; j++)
                {
                    row.Add(tr[i - 1][j - 1] + tr[i - 1][j]);
                }
                if (i != 0)
                    row.Add(1);
                tr.Add(row);
            }
            return tr;
        }

        public static void PrintList(List<int> list)
        {
            Console.Write("[");
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i].ToString());
                if (i != list.Count - 1)
                    Console.Write(" ");
            }
            Console.Write("]");
        }
    }
}