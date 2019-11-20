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
            if (value <= node.Value && node.Left != null)
            {
                Insert(node.Left, value);
            }
            else if (value <= node.Value)
            {
                node.Left = new Node(value);
            }
            else if (value > node.Value && node.Right != null)
            {
                Insert(node.Right, value);
            }
            else if (value > node.Value)
            {
                node.Right = new Node(value);
            }
        }
    }
}
