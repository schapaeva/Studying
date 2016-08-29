using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLevelOrderTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {


        }

        public static List<List<int>> LevelOrderBottom(TreeNode root) {
            List<List<int>> res = new List<List<int>>();
            if (root == null) return res;
        
            //Queue<TreeNode>
        }
    }



    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}
