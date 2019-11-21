using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(int value)
        {
            Root = new Node(value);
        }

        public void Insert(int value)
        {
            Insert(Root, value);
        }

        private void Insert(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left != null)
                {
                    Insert(node.Left, value);
                }
                else
                {
                    node.Left = new Node(value);
                }
            }
            else if (value > node.Value)
            {
                if (node.Right != null)
                {
                    Insert(node.Right, value);
                }
                else
                {
                    node.Right = new Node(value);
                }
            }
        }

        public bool Find(int value)
        {
            return Find(Root, value);
        }

        private bool Find(Node node, int value)
        {
            if (value < node.Value && node.Left != null)
            {
                return Find(node.Left, value);
            }
            else if (value > node.Value && node.Right != null)
            {
                return Find(node.Right, value);
            }

            return node.Value == value;
        }

        public void PreOrder()
        {
            PreOrder(Root);
        }

        private void PreOrder(Node node)
        {
            Console.Write(node.Value + " -> ");
            
            if (node.Left != null)
            {
                PreOrder(node.Left);
            }
            if (node.Right != null)
            {
                PreOrder(node.Right);
            }
        }

        public void InOrder()
        {
            InOrder(Root);
        }

        private void InOrder(Node node)
        {
            if (node.Left != null)
            {
                InOrder(node.Left);
            }
            
            Console.Write(node.Value + " -> ");

            if (node.Right != null)
            {
                InOrder(node.Right);
            }
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }

        private void PostOrder(Node node)
        {
            if (node.Left != null)
            {
                PostOrder(node.Left);
            }
            if (node.Right != null)
            {
                PostOrder(node.Right);
            }
            
            Console.Write(node.Value + " -> ");
        }

        public void BreadthFirst()
        {
            var queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.TryDequeue(out var node))
            {                
                Console.Write(node.Value + " -> ");

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }
}
