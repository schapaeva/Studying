using System;
using System.Collections.Generic;

namespace GetAllPaths
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
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);

            List<string> paths = new List<string>();

            if (root != null)
            {
                int[] path = new int[1000];         
                TreeTraversal(root, paths, path, 0);
            }

            foreach(string str in paths)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }

        public static void TreeTraversal(TreeNode node, IList<string> pathStrings, int[] path, int pathLen)
        {
            if (node == null) return;
            path[pathLen] = node.val;
            pathLen++;

            if (node.left == null && node.right == null)
                pathStrings.Add(GeneratePath(path, pathLen));
            else
            {
                TreeTraversal(node.left, pathStrings, path, pathLen);
                TreeTraversal(node.right, pathStrings, path, pathLen);
            }
        }

        public static string GeneratePath(int[] path, int len)
        {
            string pathString = "";
            for (int i = 0; i < len; i++)
            {
                pathString += path[i];
                if (i != len - 1) pathString += "->";
            }
            return pathString;
        }
    }
}
