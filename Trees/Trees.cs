// See https://aka.ms/new-console-template for more information
using System;

namespace BinarySearchTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            Console.WriteLine("Binary Search Tree:");
            tree.Display();

            Console.WriteLine("\nEnter a value to search for: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (tree.Search(value))
            {
                Console.WriteLine("{0} is found in the tree.", value);
            }
            else
            {
                Console.WriteLine("{0} is not found in the tree.", value);
            }

            Console.ReadLine();
        }
    }

    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            root = InsertRec(root, data);
        }

        private Node InsertRec(Node current, int data)
        {
            if (current == null)
            {
                current = new Node(data);
            }
            else if (data < current.Data)
            {
                current.Left = InsertRec(current.Left, data);
            }
            else if (data > current.Data)
            {
                current.Right = InsertRec(current.Right, data);
            }

            return current;
        }

        public bool Search(int value)
        {
            return SearchRec(root, value);
        }

        private bool SearchRec(Node current, int value)
        {
            if (current == null)
            {
                return false;
            }
            else if (current.Data == value)
            {
                return true;
            }
            else if (current.Data > value)
            {
                return SearchRec(current.Left, value);
            }
            else
            {
                return SearchRec(current.Right, value);
            }
        }

        public void Display()
        {
            Inorder(root);
        }

        private void Inorder(Node node)
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.Write(node.Data + " ");
                Inorder(node.Right);
            }
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}

