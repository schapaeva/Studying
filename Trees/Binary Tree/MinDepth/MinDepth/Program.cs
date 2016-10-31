using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDepth
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);

            MinDepth(root);
        }

        public static void TreeTraversal(TreeNode node, List<int> depths, int level)
        {
            if (node == null) return;
            level++;
            if (node.left == null && node.right == null)
                depths.Add(level);
            else
            {
                TreeTraversal(node.left, depths, level);
                TreeTraversal(node.right, depths, level);
            }
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            List<int> depths = new List<int>();
            TreeTraversal(root, depths, 0);
            return depths.Min();
        }
    }
}
}
