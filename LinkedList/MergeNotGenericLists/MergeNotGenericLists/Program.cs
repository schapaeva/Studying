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

            ListNode head = new ListNode(0);
            
            ListNode current = head;

            while (l2 != null && l1 != null)
            {
                if (l1 == null)
                {
                    current.next = l2;
                    break;
                }
                if (l2 == null)
                {
                    current.next = l1;
                    break;
                }
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }
            return head.next;
        }

        public static void PrintLinkedLest(ListNode root)
        {
            while(root != null)
            {
                Console.Write(root.val.ToString() + " ");
                root = root.next;
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
