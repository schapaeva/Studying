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

        public bool IsSameTree(Node root1, Node root2)
        {
            if (root1 == null && root2 == null)
                return true;
            if (root1 == null || root2 == null)
                return false;
            else if (root1.number == root2.number)
            {
                return IsSameTree(root1.leftLeaf, root2.leftLeaf) && IsSameTree(root1.rightLeaf, root2.rightLeaf);
            }
            return false;
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
