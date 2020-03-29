using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kocaeli_Travel_App
{
    public class MyList<T>
    {
     
        public Node<T> _head;
        public T Data;
        public void myAdd(T d)
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
                //TODO neden current'teki değişiklik _head'ı etkiliyor traverse işlemi

            }
        }
        
  
        public MyList<T> Find(T node)
        {
            return Find(node, _head);
        }
        public MyList<T> Find(T node, MyList<T> start)
        {
            MyList<T> iterator = start;
            while(iterator!=null)
            {
                if (iterator.Data.Equals(node)) return iterator;
                iterator = iterator.Next;
                
                
            }
            return null;
        }
    }
}
