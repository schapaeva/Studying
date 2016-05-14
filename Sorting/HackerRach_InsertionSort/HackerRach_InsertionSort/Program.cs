using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRach_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            insertionSort(_ar);
            Console.ReadKey();
        }

        public static void insertionSort(int[] A)
        {
            for (var i = 1; i < A.Length; i++)
            {
                for (int j = i - 1; j >= 0 && A[i] < A[j]; j--)
                {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
            Console.WriteLine(string.Join(" ", A));
        }
    }
}
