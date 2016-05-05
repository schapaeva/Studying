using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();
            listA.Add("1");
            listA.Add("2");
            listA.Add("3");
            listA.Add("4");

            listB.Add("1");
            listB.Add("2");
            listB.Add("3");

            Console.WriteLine(listA.CompareTo(listB).ToString());
            
            Console.ReadLine();
        }
    }
}
