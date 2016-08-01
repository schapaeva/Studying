using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonAndDifferentNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first array of digits: ");
            int[] array1 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            Console.Write("\nEnter second array of digits: ");
            int[] array2 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            Console.Write("\nOverlaps: ");
            PrintArray(ArraysOverlap(array1, array2));
            Console.Write("\nDifference: ");
            PrintArray(ArraysDifference(array1, array2));
            Console.ReadKey();
        }

        public static int[] ArraysOverlap(int[] array1, int[] array2)
        {
            HashSet<int> hashset1 = new HashSet<int>(array1);
            HashSet<int> hashset2 = new HashSet<int>(array2);
            hashset1.IntersectWith(array2);
            return hashset1.ToArray();
        }

        public static int[] ArraysDifference(int[] array1, int[] array2)
        {
            HashSet<int> hashset1 = new HashSet<int>(array1);
            HashSet<int> hashset2 = new HashSet<int>(array2);
            hashset1.SymmetricExceptWith(array2);
            return hashset1.ToArray();
        }     

        public static void PrintArray(int[] array)
        {
            //Console.Write("\n");
            foreach(int number in array)
            {
                 Console.Write(number.ToString() + " ");
            }
        }


    }
}
