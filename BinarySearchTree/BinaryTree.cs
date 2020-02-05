using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        Leaf<T> start;
        Leaf<T> current;


        public BinaryTree()
        {

        }


        public void AddLeaf(T input)
        {
            if (start == null)
            {
                Leaf<T> newLeaf = new Leaf<T>(input);
                start = newLeaf;
                current = newLeaf;
                return;
            }
            if (current.data.CompareTo(input) == -1)
            {
                if (current.childR == null)
                {
                    Leaf<T> newLeaf = new Leaf<T>(input);

                    current.childR = newLeaf;
                    current = start;

                    Console.WriteLine(input + " added");
                }
                else
                {
                    current = current.childR;
                    AddLeaf(input);
                }
            }
            else if(current.data.CompareTo(input) == 1)
            {
                if (current.childL == null)
                {
                    Leaf<T> newLeaf = new Leaf<T>(input);

                    current.childL = newLeaf;
                    current = start;
                    Console.WriteLine(input + " added");
                }
                else
                {
                    current = current.childL;
                    AddLeaf(input);
                }
            }
            else
            {
                current = start;
            }
        }

        public Leaf<T> Search(T input)
        {
            if (start == null)
            {
                Leaf<T> output = current;

                current = start;
                return output;
            }

            if (current.data.CompareTo(input) == 0)
            {
                return current;
            }
            else
            {
                if (current.data.CompareTo(input) == -1)
                {
                    if (current.childR != null)
                    {
                        current = current.childR;
                        return Search(input);
                    }
                }
                else if (current.data.CompareTo(input) == 1)
                {
                    if (current.childL != null)
                    {
                        current = current.childL;
                        return Search(input);
                    }
                }

            }

            return null;

        }

    }
}
