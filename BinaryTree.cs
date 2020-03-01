using System;

namespace myBinaryTree
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        //class variables
        Node root;
        // Ctor
        public BinaryTree()
        {
            root = null;
        }
        //public function declarations
        public void PrintInorder()
        {
            _inorder(root);
        }
        public void PrintPreorder()
        {
            _preorder(root);
        }
        public void InsertNode(Node newnode)
        {
            _insertnode(newnode,root);
        }
        public int size()
        {
            return size(root);
        }
        public int depth()
        {
            return depth(root);
        }
        
        public void PrintTree()
        {
            int d = depth(root);
            for(int i =1; i <= d; i++)
             _printTreeLevel(root, i);
        }

        //helper functions

        void _printTreeLevel(Node n, int level)
        {
            if (level == 1)
                Console.Write(n.key + " ");

            else if (level > 1)
            {
                _printTreeLevel(n.left, level - 1);
                _printTreeLevel(n.right, level - 1);
            }
        }
            
            
        void _insertnode(Node newnode, Node rootnode)
        {
            // check if new node is null, in which case exit.
            if (newnode == null)
                return;
            // check if root is null, in this case assign the new node to root and exit.
            if (root == null)
            {
                root = new Node(newnode.key);
                return;
            }

            // check if they are equal, exit if they are equal.
            if (newnode.key == rootnode.key)
                return;

            if (newnode.key < rootnode.key)
            {
                if (rootnode.left == null)
                    rootnode.left = new Node(newnode.key);
                else
                    _insertnode(newnode, rootnode.left);

            }

            else
            {
                if (rootnode.right == null)
                    rootnode.right = new Node(newnode.key);
                else
                    _insertnode(newnode, rootnode.right);

            }
            Console.WriteLine("Node added Successfully");
        }

        // traversal functions
        void _inorder(Node node)
        {
            if (node == null)
                return;

            _inorder(node.left);

            Console.Write(node.key + " ");

            _inorder(node.right);

        }

        void _preorder(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.key + " ");

            _preorder(node.left);
            _preorder(node.right);

        }

        int size(Node node)
        {
            if (node == null)
                return 0;
            return (size(node.left) + 1 + size(node.right));
        }

        int depth(Node node)
        {
            if (node == null)
                return 0;

            int ldepth = depth(node.left);
            int rdepth = depth(node.right);

            if (ldepth > rdepth)
                return (ldepth + 1);
            else
                return (rdepth + 1);
        }

        public void CreateTree()
        {
            root = new Node(5);

            root.left = new Node(2)
            {
                left = new Node(1),
                right = new Node(3)
            };
            root.right = new Node(6)
            {
                left = new Node(4),
                right = new Node(7)
            };
            Console.WriteLine("Tree created successfully.");
        }
    }
}