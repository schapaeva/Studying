using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineIntArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Question: combine two integers arrays. Example: array1 = [1, 2, 3], array2 = [3, 4, 5]
            //Some clarrification is needed for this questions. Should we combine only unque value? 
            //Should new values get to the end of the first array or just get to the end? Should array be sorted? 
            int[] array1 = new int[]{1, 2, 2, 3};
            int[] array2 = new int[]{-1, 0, 2};
            PrintArray(array1);
            PrintArray(array2);
            PrintArray(CombineIntegersArray(array1, array2));
            PrintArray(CombineUniqueIntegers(array1, array2));
            PrintArray(CombineUniqueIntegersHashSet(array1, array2));
            Console.ReadKey();
        }

        //Implementation without build-in fuctions: no sorting, no filtering
        public static int[] CombineIntegersArray(int[] array1, int[] array2)
        {
            int[] combinedArray = new int[array1.Length + array2.Length];
            for(int i = 0; i < array1.Length; i++)
                combinedArray[i] = array1[i];
            for (int i = 0; i < array2.Length; i++)
                combinedArray[array1.Length + i] = array2[i];
            return combinedArray;
        }

        //IF WE NEED UNIQUE VALUES ONLY
        //Implementation using HashSet to get unigue numbers
        public static int[] CombineUniqueIntegersHashSet(int[] array1, int[] array2)
        {
            HashSet<int> hash = new HashSet<int>(array1);
            hash.UnionWith(array2);
            return hash.ToArray();
        }

        //IF WE NEED UNIQUE VALUES ONLY
        //Implementation without build-in fuctions
        public static int[] CombineUniqueIntegers(int[] array1, int[] array2)
        {
            int[] combinedArray = CombineIntegersArray(array1, array2);
            int[] uniqueArray = new int[combinedArray.Length];
            //Example: 1 2 2 3 -1 0 2 -> 1 3 -1 0 2
            int adj = 0;
            for (int i = 0; i < combinedArray.Length; i++)
            {

                bool found = false;
                for (int j = i + 1; j < combinedArray.Length; j++)
                {
                    if (combinedArray[i] == combinedArray[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    uniqueArray[i - adj] = combinedArray[i];
                else
                    adj++;
            }
            return uniqueArray;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var value in array)
                Console.Write(value.ToString() + " ");
            Console.Write("\n");
        }

    }
}
