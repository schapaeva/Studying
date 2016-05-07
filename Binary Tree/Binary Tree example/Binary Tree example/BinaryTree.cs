using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_example
{
    class BinaryTree
    {
        private Node root;

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

        public override string ToString()
        {
            string result = string.Empty;
            if (!IsEmpty)
                result = root.ToString();
            return result;
        }
    }
}
