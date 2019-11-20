using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinarySearchTree(5);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(7);
        }
    }
}
