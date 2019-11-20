using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinarySearchTree(4);

            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(3);

            tree.Insert(6);
            tree.Insert(5);
            tree.Insert(7);

            tree.PreOrder();
            Console.WriteLine();
            tree.InOrder();
            Console.WriteLine();
            tree.PostOrder();
            Console.WriteLine();
        }
    }
}
