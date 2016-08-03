﻿using System;
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
            int[] temp = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            LinkedList<int> list1 = new LinkedList<int>(temp);
            temp = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            LinkedList<int> list2 = new LinkedList<int>(temp);
            PrintLinkedList(MergeLists(list1, list2));
            Console.ReadKey();
        }

        public static LinkedList<int> MergeLists(LinkedList<int> list1, LinkedList<int> list2)
        {
            if (list1.First == null)
                return list2;
            if (list2.First == null)
                return list1;
            //1: 1-2-2-3-4  
            //2: 0-3-7
            LinkedListNode<int> current2 = list2.First;
            while(current2 != null)
            {
                LinkedListNode<int> current1 = list1.First;
                while(current2.Value > current1.Value && current1.Next != null)
                {                           
                    current1 = current1.Next;
                }

                if (current1.Next == null)
                    list1.AddAfter(current1, current2.Value);
                else
                    list1.AddBefore(current1, current2.Value);
                current2 = current2.Next;
            }
            return list1;
        }

        public static void PrintLinkedList(LinkedList<int> list)
        {
            Console.WriteLine("Linked list: ");
            foreach(int i in list)
            {
                Console.Write(i.ToString() + " ");
            }
        }
    }
}