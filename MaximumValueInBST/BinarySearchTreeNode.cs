using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumValueInBST
{
    class BinarySearchTreeNode
    {
        int data;
        BinarySearchTreeNode left;
        BinarySearchTreeNode right;

        public BinarySearchTreeNode() { }

        public BinarySearchTreeNode(int data) {
            this.data = data;
        }

        public int GetBinarySearchTreeNodeData() {
            return data;
        }

        public BinarySearchTreeNode GetBinarySearchTreeNodeLeft(){
            return left;
        }

        public BinarySearchTreeNode GetBinarySearchTreeNodeRight() {
            return right;
        }

        public void SetBinarySearchTreeNodeLeft(BinarySearchTreeNode binarySearchTreeNode)
        {
            left = binarySearchTreeNode;
        }

        public void SetBinarySearchTreeNodeRight(BinarySearchTreeNode binarySearchTreeNode)
        {
            right = binarySearchTreeNode;
        }
    }
}
