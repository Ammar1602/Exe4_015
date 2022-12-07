using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_015
{
    class Node
    {
        public int info;
        public Node next;

        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }
}
