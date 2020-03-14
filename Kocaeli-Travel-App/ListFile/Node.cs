using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocaeli_Travel_App
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T d)
        {
            Data = d;
            Next = null;
        }
    }
}
