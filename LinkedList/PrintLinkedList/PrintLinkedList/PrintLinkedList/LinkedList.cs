using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLinkedList
{
    public class LinkedList
    {
        private Node head;
        private int count; 

        public LinkedList()
        {
            this.head = null;
            this.count = 0;            
        }

        public bool Empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object this[int index]
        {
            get { return this.Get(index); }
        }

        public object Add(int index, object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index.ToString() + " is out of the range.");
            if (index > count)
                index = count;

            Node current = this.head;

            if (this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(o, current.Next);
            }

            count++;
            return o;
        }

        public object Add(object o)
        {
            return this.Add(count, o);
        }

        public object Remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index.ToString() + " is out of the range.");
            if (this.Empty)
                return null;
            if (index >= this.count)
                index = count-1;

            Node current = this.head;
            object result = null;
            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }

        public void Clear()
        {
            this.head = null;
            this.count = 0;
        }

        public int IndexOf(object o)
        {
            Node current = this.head;
            for (int i = 0; i < this.Count; i++)
            {
                if (current.Data.Equals(o))
                    return i;
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(object o)
        {
            return this.IndexOf(0) >= 0;
        }

        public object Get (int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index.ToString() + " is out of the range.");
            if (this.Empty)
                return null;
            if (index >= this.count)
                index = count-1;

            Node current = this.head;
            for (int i = 0; i < index; i++)
                current = current.Next;
            return current.Data;
        }

        public void PrintList()
        {
            Node current = this.head;
            if (Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            for (int i = 0; i < Count; i++)
            {
                Console.Write(current.Data.ToString());
                if (current.Next != null)
                    Console.Write("->");
                current = current.Next;
            }
            Console.Write("\n");
        }

        public void PrintReverseList()
        {
            Node current = this.head;
            if (Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            string printLine = "";
            for (int i = 0; i < Count; i++)
            {
                printLine = current.Data.ToString() + printLine;
                if (current.Next != null)
                    printLine = "->" + printLine;
                current = current.Next;
            }
            Console.Write(printLine + "\n");
        }

        public void ReverseList()
        {
            Node tmp = this.head;
            Node next = null;
            Node prevItem = null;

            while (tmp != null)
            {
                //Make a new node and copy tmp
                next = new Node(tmp.Data, prevItem);                
                prevItem = next;
                tmp = tmp.Next;
            }
            this.head = next;         
        }

        public bool CompareTo(LinkedList comparedList)
        {
            Node currentA = this.head;
            Node currentB = comparedList.head;
            if (this.Count == comparedList.Count)
            {
                if (this.Count == 0)
                    return true;
                while (currentA != null)
                {
                    if (currentA.Data.Equals(currentB.Data))
                    {
                        currentA = currentA.Next;
                        currentB = currentB.Next;
                    }
                    else
                        return false;
                }
                return true;
            }
            return false;
        }

        public LinkedList MergeWith(LinkedList mergeList)
        {
            Node currentA = this.head;
            Node currentB = mergeList.head;

            if (this.Count == 0)
                return mergeList;
            if (mergeList.Count == 0)
                return this;

            while (currentB != null)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (currentA != null)
                    {
                        if (Int32.Parse(currentB.Data.ToString()) <= Int32.Parse(currentA.Data.ToString()))
                        {
                            this.Add(i, currentB.Data);
                            break;
                        }
                        else
                            currentA = currentA.Next;
                    }
                    else
                    {
                        this.Add(currentB.Data);
                        break;
                    }
                }
                currentA = this.head;
                currentB = currentB.Next;
            }
            return this;
        }

    }
}
