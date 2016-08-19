using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerestParent
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null) return null;
            if (root == p || root == q) return root;
            int totalMatches = countMatchesPQ(root.left, p, q);
            if (totalMatches == 1)
                return root;
            else if (totalMatches == 2)
                return LowestCommonAncestor(root.left, p, q);
            else /* totalMatches == 0 */
                return LowestCommonAncestor(root.right, p, q);
        }

        public int countMatchesPQ(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return 0;
            int matches = countMatchesPQ(root.left, p, q) + countMatchesPQ(root.right, p, q);
            if (root == p || root == q)
                return 1 + matches;
            else
                return matches;
        }
    }
}
