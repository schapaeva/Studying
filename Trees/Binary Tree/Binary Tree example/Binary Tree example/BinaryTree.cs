using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_example
{
    class BinaryTree
    {
        public Node root;

        public bool IsEmpty
        {
            get { return root == null; }
        }

        public int Count { get; private set; }

        public BinaryTree()
        {
            root = null;
            Count = 0;
        }

        public void Insert(int data)
        {
            if (IsEmpty)
                root = new Node(data);
            else
                root.InsertData(data);
            Count++;
        }

        public bool Search(int toSearch)
        {
            return root.Search(toSearch);
        }

        public void Display()
        {
            if (!IsEmpty)
            {
                root.Display(root);
            }
        }

        //Time complexity O(n)
        public int GetHeight(Node root)
        {
            if (root == null)
                return 0;
            return (1 + Math.Max(GetHeight(root.leftLeaf), GetHeight(root.rightLeaf)));
        }

        public override string ToString()
        {
            string result = string.Empty;
            if (!IsEmpty)
                result = root.ToString();
            return result;
        }
    }
}
