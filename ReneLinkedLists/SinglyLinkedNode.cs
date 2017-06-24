using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReneLinkedLists
{
    public class SinglyLinkedNode<T>
    {
        public T Item { get; set; }
        public SinglyLinkedNode<T> Next { get; set; }
        public SinglyLinkedNode(T item, SinglyLinkedNode<T> next = null)
        {
            Item = item;
            Next = next;
        }

        public void AddAfter(T itemToAdd)
        {
            SinglyLinkedNode<T> NextNode = new SinglyLinkedNode<T>(itemToAdd);
            NextNode.Next = Next;
            Next = NextNode;
        }

        public void RemoveNext()
        {
            Next = Next.Next;
        }
    }
}
