using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp_arr = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(temp_arr, Int32.Parse);
            int n = arr[0];
            int q = arr[1];
            int lastAns = 0;
            List<int[]> inputArray = new List<int[]>();
            List<List<int>> seqList = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                List<int> emptyList = new List<int> { };
                seqList.Add(emptyList);
            }

            for (int i = 0; i < q; i++)
            {
                temp_arr = Console.ReadLine().Split(' ');
                inputArray.Add(Array.ConvertAll(temp_arr, Int32.Parse));
            }

            foreach (int[] line in inputArray)
            {
                if (line[0] == 1)
                {
                    Sequence1(seqList, line[1], line[2], lastAns, n);
                }
                else if (line[0] == 2)
                {
                    lastAns = Sequence2(seqList, line[1], line[2], lastAns, n);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }                    
            }
            Console.ReadLine();
        } //end of Main

        public static void Sequence1(List<List<int>> seqList, int x, int y, int lastAns, int n)
        {
            int index = (x ^ lastAns) % n;
            seqList[index].Add(y); 
        }

        public static int Sequence2(List<List<int>> seqList, int x, int y, int lastAns, int n)
        {
            int index = (x ^ lastAns) % n;
            int size = seqList[index].Count;
            lastAns = seqList[index][y % size];

            Console.WriteLine(lastAns);
            return lastAns;
        }

    }
}
