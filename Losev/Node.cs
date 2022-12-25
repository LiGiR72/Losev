namespace ConsoleApp2
{
    internal class BinaryTree
    {
        public Node? Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }
        internal class Node
        {
            public int Key { get; set; }
            public int Index { get; set; }
            public Node? LTree { get; set; }
            public Node? RTree { get; set; }

            public Node(int key)
            {
                Key = key;
                LTree = null;
                RTree = null;
            }         
        }
        public void Add(int key)
        {
            Root = AddUtility(key, Root);
        }
        public Node AddUtility(int key, Node node)
        {
            if (node == null)
            {
                node = new Node(key);
                return node;
            }
            if (node.Key > key)
            {
                node.LTree = AddUtility(key, node.LTree);
            }
            else if (node.Key < key)
            {
                node.RTree = AddUtility(key, node.RTree);
            }
            return node;

        }
        public void inorder() { inorderRec(Root); }
        void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.LTree);
                Console.WriteLine(root.Key);
                inorderRec(root.RTree);
            }
        }
    }
}
