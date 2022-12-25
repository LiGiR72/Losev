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
        public void Add(int key) => Root = AddUtility(key, Root);
        private Node AddUtility(int key, Node? node)
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
        public Node Delete(int key) => DeletionUtility(Root, key);

        private Node DeletionUtility(Node? root, int key)
        {
            if (root == null)
            {
                return root;
            }
            if (key < root.Key)
                root.LTree = DeletionUtility(root.LTree, key);
            else if (key > root.Key)
                root.RTree = DeletionUtility(root.RTree, key);          
            else
            {              
                if (root.LTree == null)
                    return root.RTree;
                else if (root.RTree == null)
                    return root.LTree;
                root.Key = minValue(root.RTree);
                root.RTree = DeletionUtility(root.RTree, root.Key);
            }
            return root;
        }
        int minValue(Node? root)
        {
            int minv = root.Key;
            while (root.LTree != null)
            {
                minv = root.LTree.Key;
                root = root.LTree;
            }
            return minv;
        }
        public void inorder() => inorderRec(Root);
        private void inorderRec(Node? root)
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
