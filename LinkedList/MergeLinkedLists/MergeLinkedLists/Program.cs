using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            int iterations;
            int[] temp = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            LinkedList<int> list1 = new LinkedList<int>(temp);
            temp = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            LinkedList<int> list2 = new LinkedList<int>(temp);
            PrintLinkedList(MergeLists(list1, list2, out iterations));
            Console.WriteLine("\nIterations: " + iterations.ToString());
            Console.ReadKey();
        }

        public static LinkedList<int> MergeLists(LinkedList<int> list1, LinkedList<int> list2, out int iterations)
        {
            iterations = 0;
            if (list1.First == null)
                return list2;
            if (list2.First == null)
                return list1;

            LinkedListNode<int> current2 = list2.First;
            LinkedListNode<int> current1 = list1.First;
            while (current2 != null)
            {                
                while (current2.Value > current1.Value && current1 != list1.Last)
                {                           
                    current1 = current1.Next;
                    iterations++;
                }

                if (current2.Value > current1.Value)
                {
                    list1.AddAfter(current1, current2.Value);
                    current1 = current1.Next;
                }
                else
                {
                    list1.AddBefore(current1, current2.Value);
                    current1 = current1.Previous;
                }
                current2 = current2.Next;
                iterations++;
            }
            return list1;
        }

        public static void PrintLinkedList(LinkedList<int> list)
        {
            Console.WriteLine("\nLinked list: ");
            foreach(int i in list)
            {
                Console.Write(i.ToString() + " ");
            }
        }
    }
}
