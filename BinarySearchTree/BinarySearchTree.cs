using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;
        public Node current;
        public int value;
        public bool isTrue = false;

        public bool Search(int value)
        {
            if(root == null)
            {
                return false;
            }
            current = root;
            
            while(true)
            {
                if (current.data == value)
                {
                    return true;
                }
                if (current.data > value)
                {
                    if ( current.leftChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.leftChild;
                    }                 
                }
                else if (current.data < value)
                {
                    if (current.rightChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }

            }
        }
        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return;
            }
            if (value >= root.data)
            {
                if (root.rightChild == null)
                {
                    root.rightChild = new Node(value);
                    return;
                }
            }
            if (value <= root.data)
            {
                if (root.leftChild == null)
                {
                    root.leftChild = new Node(value);
                    return;
                }
            }
            current = root;

            while (true)
            {
                if (current.data > value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = new Node(value);
                        break;
                    }
                    else
                    {
                        current = current.leftChild;
                    }
                }
                if (current.data < value)
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = new Node(value);
                        break;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }

            }
        }
    } 
}
