using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;
        public Node(int incomingData)
        {
            data = incomingData;
        }
    }
}
