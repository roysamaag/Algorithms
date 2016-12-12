using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public Node Create()
        {
            Node first = new Node();
            Node second = new Node();
            Node third = new Node();
            Node fourth = new Node();
            Node fifth = new Node();
            Node sixth = new Node();

            first.Name = "First";
            first.Next = second;
            first.Age = 10;

            second.Name = "Second";
            second.Next = third;
            second.Age = 20;

            third.Name = "Third";
            third.Next = fourth;
            third.Age = 60;

            fourth.Name = "Fourth";
            fourth.Next = fifth;
            fourth.Age = 30;

            fifth.Name = "Fifth";
            fifth.Next = sixth;
            fifth.Age = 15;

            sixth.Name = "Sixth";
            sixth.Next = null;
            sixth.Age = 12;

            //Print(first);

            return first;
        }


        private void Print(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Name);
                node = node.Next;
            };
        }

        public void Sort()
        {
            var node = Create();

            while (node != null)
            {
                Node temp = null;

                if (node.Age > node.Next.Age)
                {
                    temp = node;
                    node = node.Next;
                    node.Next = temp;
                }
                Console.WriteLine(node.Name);
                node = node.Next;
            };
        }

        public void InsertFront(Node insertNode)
        {
            var node = Create();

            if (node != head)
            {
                while (node.Next != null)
                {
                    //if (node.Name == "First")
                    //{

                        insertNode.Next = node;
                        node = insertNode;
                        break;
                    //}
                }
                Print(node);
            }
        }

        public void InsertEnd(Node insertNode)
        {
            var node = Create();
            Node temp = node;

            if (node != head)
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = insertNode;
                Print(node);
            }
        }

        public void InsertAfterPosition(Node insertNode, string name)
        {
            var node = Create();
            Node temp = node;

            if (node != head)
            {
                while (temp.Next != null || (temp.Next == null && temp.Name == name))
                {
                    if (temp.Name == name)
                    {
                        var tempPos = temp.Next;
                        temp.Next = insertNode;
                        insertNode.Next = tempPos;
                        break;
                    }
                    else
                        temp = temp.Next;
                }
                
                Print(node);
            }
        }

        public void InsertBeforePosition(Node insertNode, string name)
        {
            var node = Create();
            Node prev = null;
            Node current = node;

            if (node != head)
            {
                while (current.Next != null || (current.Next == null  && current.Name == name))
                {
                    if (current.Name == name)
                    {
                        var tempPos = prev.Next;
                        prev.Next = insertNode;
                        insertNode.Next = tempPos;
                        break;
                    }
                    else
                    {
                        prev = current;
                        current = current.Next;
                    }
                }

                Print(node);
            }
        }

        public void Delete(string name)
        {
            var node = Create();
            Node prev = null;
            Node current = node;

            if (node != head)
            {
                while (current.Next != null || (current.Next == null && current.Name == name))
                {
                    if (current.Name == name)
                    {
                        prev.Next = current.Next;
                        break;
                    }
                    else
                    {
                        prev = current;
                        current = current.Next;
                    }
                }

                Print(node);
            }
        }


        public void DeleteFrontNode()
        {
            var node = Create();
            Node current = node;

            if (node != head)
            {

                while (current.Next != null)
                {
                    current = current.Next;
                    break;
                }
                node = current;
                Print(node);
            }
        }

        public void DeleteTailNode()
        {
            var node = Create();
            Node current = node;
            Node previous = null;

            if (node != head)
            {
                while (current.Next != null)
                {
                    previous = current;
                    current = current.Next;
                }

                current = null;
                previous.Next = current;

                Print(node);
            }
        }
    }

}
