using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReneLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            int answer;
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1) Add new item to end of list. 2) Add new item to front of list.\n3) Remove item from end. 4) Remove item from front.");
                Console.WriteLine("5) Remove item at specified index position. 6) View list items\n7) Exit");

                answer = int.Parse(Console.ReadLine());
                //Console.SetCursorPosition(0, Console.CursorTop - 1);
                //Console.Write(" \n");

                switch (answer)
                {
                    case 1:
                        {
                            AddNewItemEnd(list);
                            break;
                        }

                    case 2:
                        {
                            AddNewItemFront(list);
                            break;
                        }
                    case 3:
                        {
                            list.RemoveFromEnd();
                            break;
                        }
                    case 4:
                        {
                            list.RemoveFromFront();
                            break;
                        }
                    case 5:
                        {
                            RemoveItemFromIndex(list);
                            break;
                        }
                    case 6:
                        {
                            DisplayList(list);
                            break;
                        }
                    case 7:
                        {
                            cont = false;
                            break;
                        }
                }

                Console.WriteLine();
            }
        }

        static void AddNewItemEnd(SinglyLinkedList<int> list)
        {
            Console.WriteLine("What number would you like to add?");
            int num = int.Parse(Console.ReadLine());

            list.AddToEnd(num);
        }

        static void AddNewItemFront(SinglyLinkedList<int> list)
        {
            Console.WriteLine("What number would you like to add?");
            int num = int.Parse(Console.ReadLine());

            list.AddToFront(num);
        }

        static void RemoveItemFromIndex(SinglyLinkedList<int> list)
        {
            Console.WriteLine("What number item would you like to remove?");
            int index = int.Parse(Console.ReadLine());

            list.RemoveAt(index - 1);
        }

        static void DisplayList(SinglyLinkedList<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                SinglyLinkedNode<int> node = list.Head;

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {node.Item}");
                    node = node.Next;
                }
            }
        }
    }
}
