using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    public class Stack<T>
    {
        Node<T> head;

        public Stack()
        {
            head = null;
        }

        public void push(T item)
        {
            head = new Node<T>(item, head);
        }

        public T pop()
        {
            if (head == null)
                throw new Exception("Stack is Empty");
            T item = head.item;
            head = head.next;
            return item;
        }

        public IEnumerable<T> list()
        {
            Node<T> node = head;
            while (node != null)
            {
                yield return node.item;
                node = node.next;
            }
        }
    }
}
