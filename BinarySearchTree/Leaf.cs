using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Leaf<T> where T : IComparable
    {
        public Leaf<T> childR;
        public Leaf<T> childL;
        public T data;

        public Leaf(T input)
        {
            data = input;
        }


    }
}
