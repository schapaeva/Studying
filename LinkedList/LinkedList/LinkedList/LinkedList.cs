using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
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

        public object Add(int index, object o)
        {
            if (index < 0 || index > this.count - 1)
                throw new ArgumentOutOfRangeException("Index is out of range.");
            
            Node current = this.head;
            
            if (Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index; i++)
                {

                }
            }
        }

    }
}
