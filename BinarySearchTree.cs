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

        public void Delete(int value)
        {
            Root = Delete(Root, value);
        }

        private Node Delete(Node node, int value)
        {
            if (node == null)
            {
                return node;
            }
            else if (value < node.Value)
            {
                node.Left = Delete(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Delete(node.Right, value);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Value = minimumValue(node.Right);

                node.Right = Delete(node.Right, node.Value);
            }

            return node;
        }

        private int minimumValue(Node node)
        {
            int minimum = node.Value;

            while (node.Left != null)
            {
                minimum = node.Left.Value;
                node = node.Left;
            }

            return minimum;
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

        public void PreOrderIterative()
        {
            var stack = new Stack<Node>();
            stack.Push(Root);

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                Console.Write(current.Value + " -> ");

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }
                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
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

        public void PostOrderIterative()
        {
            var stack = new Stack<Node>();
            stack.Push(Root);
            var output = new Stack<Node>();

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                output.Push(current);

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }
            }

            while (output.Count > 0)
            {
                Node current = output.Pop();
                Console.Write(current.Value + " -> ");
            }
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
