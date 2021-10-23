using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    class BinaryTreeNode
    {
        public BinaryTreeNode LeftChild;
        public BinaryTreeNode RightChild;
        public string Value;
        public BinaryTreeNode(string value)
        {
            this.Value = value;
        }
        public static bool IsLeaf(BinaryTreeNode node)
        {
            if (node.LeftChild == null && node.RightChild == null)
                return true;
            return false;
        }
    }
}
