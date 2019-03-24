using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumValueInBST
{
    class BinarySearchTree
    {
        BinarySearchTreeNode root;

        public BinarySearchTree() { }

        public BinarySearchTree(BinarySearchTreeNode binarySearchTreeNode) {
            root = binarySearchTreeNode;
        }

        public void SetBinarySearchTreeRoot(BinarySearchTreeNode binarySearchTreeNode) {
            root = binarySearchTreeNode;
        }

        public BinarySearchTreeNode GetBinarySearchTreeRoot() {
            return root;
        }

        public BinarySearchTreeNode Insert(BinarySearchTreeNode root, int data) {
            if (root == null) {
                root = new BinarySearchTreeNode(data);
                return root;
            }

            if (data < root.GetBinarySearchTreeNodeData())
            {
                root.SetBinarySearchTreeNodeLeft(Insert(root.GetBinarySearchTreeNodeLeft(),
                    data));
            }
            else {
                root.SetBinarySearchTreeNodeRight(Insert(root.GetBinarySearchTreeNodeRight(),
                    data));
            }

            return root;
        }

        public void PrintInorderTraversal(BinarySearchTreeNode binarySearchTreeNode) {
            if (binarySearchTreeNode == null) {
                return;
            }
            PrintInorderTraversal(binarySearchTreeNode.GetBinarySearchTreeNodeLeft());
            Console.Write(binarySearchTreeNode.GetBinarySearchTreeNodeData()+"->");
            PrintInorderTraversal(binarySearchTreeNode.GetBinarySearchTreeNodeRight());

        }

        public void PrintMaxValueInBST(BinarySearchTreeNode binarySearchTreeNode)
        {
            if (binarySearchTreeNode == null) {
                Console.WriteLine("The tree is empty!");
                return;
            }

            BinarySearchTreeNode searchTreeNode = binarySearchTreeNode;
            while (searchTreeNode != null && searchTreeNode.GetBinarySearchTreeNodeRight() != null) {
                searchTreeNode = searchTreeNode.GetBinarySearchTreeNodeRight();
            }

            Console.WriteLine("The max value in the tree is "
                +searchTreeNode.GetBinarySearchTreeNodeData());
        }
    }
}
