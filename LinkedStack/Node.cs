using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    public class Node<T>
    {
        public T item { get; private set; }
        public Node<T> next { get; private set; }

        public Node(T item, Node<T> next)
        {
            this.item = item;
            this.next = next;
        }

        public override string ToString()
        {
            return item.ToString() + " " + next?.GetHashCode();
        }
    }
}
