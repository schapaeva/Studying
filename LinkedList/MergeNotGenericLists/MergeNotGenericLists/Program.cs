using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeNotGenericLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(0);
            l2.next = new ListNode(1);
            l2.next.next = new ListNode(2);
            l2.next.next.next = new ListNode(4);
            l2.next.next.next.next = new ListNode(5);
            PrintLinkedLest(MergeTwoLists(l1, l2));
            Console.ReadKey();

        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode currentL2 = l2;
            ListNode currentL1 = l1;

            while (currentL2 != null)
            {
                currentL1 = l1;
                while (currentL2.val >= currentL1.val && currentL2.val < currentL1.next.val && currentL1 != null)
                {
                    currentL1 = currentL1.next;
                }

                ListNode tempL1 = currentL1.next;
                ListNode nextL2 = currentL2.next;

                if (currentL1 == l1)
                {
                    l1 = currentL2;
                    currentL2.next = currentL1;
                }
                else if (currentL1.next == null)
                {
                    currentL1.next = currentL2;
                }
                else if (currentL1.val <= currentL2.val)
                {
                    currentL1.next = currentL2;
                    currentL2.next = tempL1;
                }
                else
                {

                }

                currentL2 = nextL2;
            }
            return l1;
        }

        public static void PrintLinkedLest(ListNode root)
        {
            while(root != null)
            {
                Console.Write(root.val.ToString() + " ");
            }
        }
    }    

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }
    }
}
