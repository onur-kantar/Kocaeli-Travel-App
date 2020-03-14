using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocaeli_Travel_App
{
    public class MyList<T>
    {
        public Node<T> _head;
        public void Add(T d)
        {

            Node<T> newNode = new Node<T>(d);
            Node<T> current = _head;

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            //ShowNodes();
        }
        public void PrintList()
        {
            Node<T> current = _head;

            if (current == null)
            {
                Console.WriteLine("No nodes to display.");
                Console.WriteLine();
            }
            else
            {
                while (current != null)
                {
                    Console.Write("|" + current.Data + "|=>");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
