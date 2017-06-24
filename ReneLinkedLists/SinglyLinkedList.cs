using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReneLinkedLists
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedNode<T> Head { get; set; }
        public SinglyLinkedList()
        {

        }

        public void AddToEnd(SinglyLinkedNode<T> node, T itemToAdd)
        {
            if (node.Next == null)
            {
                node.AddAfter(itemToAdd);
            }
            else
            {
                AddToEnd(node.Next, itemToAdd);
            }
        }

        public void AddToFront(T itemToAdd)
        {
            SinglyLinkedNode<T> node = new SinglyLinkedNode<T>(itemToAdd, Head);
            Head = node;
        }

        public void RemoveFromEnd()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Cannot remove a node from a null list");
            }

            var tempNode = Head;
            var nextTempNode = Head.Next;

            while (nextTempNode != null)
            {
                tempNode = nextTempNode;
                nextTempNode = nextTempNode.Next;
            }

            tempNode.Next = null;
        }

        public void RemoveFromFront()
        {
            Head = Head.Next;
        }

        public void RemoveAt(int index)
        {
            var node = Head;
            for (int i = 0; i < index - 1; i++)
            {
                node = node.Next;
            }
            node.Next = node.Next.Next;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public int Count()
        {
            int count = 0;
            if(IsEmpty())
            {
                return count;
            }

            count++;
            var node = Head;
            while(node.Next != null)
            {
                count++;
                node = node.Next;
            }

            return count;
        }
    }
}
