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
            Random ran = new Random();

            for(int i = 0; i < 50; i++)
            {
                int random = ran.Next(100);
                Console.WriteLine(random + " added");
                binaryTree.AddLeaf(random);
            }

            int search = ran.Next(100);
            Leaf<int> found = binaryTree.Search(search);

            if(found != null)
            {
                Console.WriteLine(search + " found");
            }
            else
            {
                Console.WriteLine(search + " not found");
            }

            Console.ReadLine();
        }
    }
}
