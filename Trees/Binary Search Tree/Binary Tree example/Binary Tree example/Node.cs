using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_example
{
    class Node
    {
        public int number;
        public Node rightLeaf;
        public Node leftLeaf;

        public Node(int value)
        {
            number = value;
            rightLeaf = null;
            leftLeaf = null;
        }

        public bool isLeaf(ref Node node)
        {
            return (node.rightLeaf == null && node.leftLeaf == null);
        }

        public void InsertData(int data)
        {
            if (number < data)
            {
                if (rightLeaf == null)
                    rightLeaf = new Node(data);
                else
                    rightLeaf.InsertData(data);
            }
            else if (number > data)
            {
                if (leftLeaf == null)
                    leftLeaf = new Node(data);
                else
                    leftLeaf.InsertData(data);
            }
        }

        public bool Search(int s)
        {
            if (number == s)
                return true;
            if (number < s)
            {
                if (rightLeaf == null)
                    return false;
                return rightLeaf.Search(s);
            }
            if (number > s)
            {
                if (leftLeaf == null)
                    return false;
                return leftLeaf.Search(s);
            }
            return false;
        }

        public void Display(Node node)
        {
            if (leftLeaf != null)
                Display(node.leftLeaf);
            if (rightLeaf != null)
                Display(node.rightLeaf);
            Console.Write(" " + node.number);
        }

    }
}
