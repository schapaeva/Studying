using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByPairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);
            PrintList(SwapPairs(head));
            Console.ReadKey();

        }
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode prev = head; // 1
            head = head.next; // 2
            ListNode current = head; // 2
            ListNode next = head.next; //3

            while (next != null)
            {
                current.next = prev; //2->1
                prev.next = next.next; //1->4

                current = next.next;
                prev = next;
                next = current.next;
            }
            current.next = prev;
            prev.next = next;
            return head;
        }
        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val.ToString() + " ");
                node = node.next;
            }
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
