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
        public int Count { get { return Length(); } }

        public SinglyLinkedList()
        {

        }

        public void AddToEnd(T itemToAdd)
        {
            var node = Head;
            if (node == null)
            {
                Head = new SinglyLinkedNode<T>(itemToAdd);
            }
            else
            {
                while (node.Next != null)
                {
                    node = node.Next;
                }

                node.Next = new SinglyLinkedNode<T>(itemToAdd);
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
            if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                var tempNode = Head;
                var nextTempNode = Head.Next;

                while (nextTempNode.Next != null)
                {
                    tempNode = nextTempNode;
                    nextTempNode = nextTempNode.Next;
                }

                tempNode.Next = null;
            }
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

        private int Length()
        {
            int count = 0;
            if (IsEmpty())
            {
                return count;
            }

            count++;
            var node = Head;
            while (node.Next != null)
            {
                count++;
                node = node.Next;
            }

            return count;
        }
    }
}
