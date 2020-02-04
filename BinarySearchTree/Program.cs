using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree<int> binaryTree = new BinaryTree<int>();

            binaryTree.AddLeaf(10);
            binaryTree.AddLeaf(5);
            binaryTree.AddLeaf(6);
            binaryTree.AddLeaf(7);
            binaryTree.AddLeaf(11);
            binaryTree.AddLeaf(19);
            binaryTree.AddLeaf(13);
            binaryTree.AddLeaf(4);

            Leaf<int> found = binaryTree.Search(14);

            if(found != null)
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value not found");
            }

            Console.ReadLine();
        }
    }
}
