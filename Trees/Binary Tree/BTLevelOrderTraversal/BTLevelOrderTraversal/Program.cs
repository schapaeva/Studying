using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLevelOrderTraversal
{

    public class Program
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
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.right = new TreeNode(7);
            root.right.right = new TreeNode(15);

            IList<IList<int>> result = new List<IList<int>>();
            List<int> rootLevel = new List<int>();
            if (root != null)
            {
                TreeTraversal(root, result, 0);
            }
        }

        public static void TreeTraversal(TreeNode node, IList<IList<int>> result, int level)
        {
            if (node == null) return;

            if (level >= result.Count)
            {
                result.Add(new List<int> { node.val });
            }
            else
            {
                result[level].Add(node.val);
            }
            if (node.left != null) TreeTraversal(node.left, result, level+1);
            if (node.right != null) TreeTraversal(node.right, result, level+1);
        }
    }



    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}
