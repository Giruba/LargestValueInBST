using System;

namespace MaximumValueInBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum value in Binary Search Tree!");
            Console.WriteLine("------------------------------------");

            BinarySearchTree binarySearchTree = GetBSTFromInput();
            binarySearchTree.PrintMaxValueInBST(binarySearchTree.GetBinarySearchTreeRoot());
            Console.ReadLine();
        }

        private static BinarySearchTree GetBSTFromInput() {
            BinarySearchTree binarySearchTree = null;

            Console.WriteLine("Enter the number of elements" +
                " in the Binary search tree");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by" +
                    " space");
                String[] elements = Console.ReadLine().Split(' ');
                binarySearchTree = new BinarySearchTree();
                BinarySearchTreeNode binarySearchTreeNode = null;
                for (int index = 0; index < noElements; index++) {

                    binarySearchTree.SetBinarySearchTreeRoot(
                        binarySearchTree.Insert(binarySearchTree.GetBinarySearchTreeRoot(),
                        int.Parse(elements[index])));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            return binarySearchTree;
        }
    }
}
