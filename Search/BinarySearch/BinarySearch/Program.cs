using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(temp, Int32.Parse);
            int searching = Convert.ToInt32(Console.ReadLine());
            int index;
            if (BinarySearch(array, searching, out index))
                Console.WriteLine("Index of the '{0}' element is {1}", searching.ToString(), index.ToString());
            else
                Console.WriteLine("Not found.");
            Console.ReadKey();
        }
        
        public static bool BinarySearch(int[] array, int searching, out int foundIndex)
        {
            foundIndex = 0;
            int middle, lowBound = 0, highBound = array.Length -1;
            while(lowBound <= highBound)
            {
                middle = (lowBound + highBound) / 2;
                if (searching < array[middle])
                {
                    highBound = middle - 1;
                }
                else if (searching > array[middle])
                {
                    lowBound = middle + 1;
                }
                else
                {
                    foundIndex = middle;
                    return true;
                }
            }
            return false ;
        }
    }
}
