using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.DS.Tree
{
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }
    public class BinarySearchTree
    {
        Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int key)
        {
            root = InsertRec(root, key);
        }

        private Node InsertRec(Node root, int key)
        {
            if(root == null)
            {
                root = new Node(key);
                return root;
            }

            if(key < root.data)
            {
                root.left = InsertRec(root.left, key);
            }
            else  if(key > root.data)
            {
                root.right = InsertRec(root.right, key);
            }

            return root;
        }

        public bool Search(int key)
        {
            return SearchRec(root, key);
        }

        private bool SearchRec(Node root, int key)
        {
            if(root == null)
            {
                return false;
            }

            if(key == root.data)
            {
                return true;
            }

            if(key < root.data)
            {
                return SearchRec(root.left, key);
            }

            return SearchRec(root.right, key);
        }

        public void InorderTraversal()
        {
            InorderTraversal(root);
            Console.WriteLine();
        }

        private void InorderTraversal(Node root)
        {
            if(root != null)
            {
                InorderTraversal(root.left);
                Console.Write(root.data + " ");
                InorderTraversal(root.right);
            }
        }

        //public void PreorderTraversal()
        //{
        //    PreorderTraversal(root);
        //    Console.WriteLine();
        //}

        //private void PreorderTraversal(Node root)
        //{
        //    if(root != null)
        //    {
        //        PreorderTraversal(root.data + " ");
        //    }
        //}
    }
}
