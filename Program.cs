using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right = new TreeNode(1);
            root.right.right = new TreeNode(0);

            TreeNode x = InvertTree(root);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root; 
            }

            TreeNode buffer = new TreeNode(0);

            buffer = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(buffer);

            return root;
        }
    }
}
