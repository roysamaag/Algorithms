using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queue
    {
        GenericNode<int> head = null;
        GenericNode<int> tail = null;
        GenericNode<string> movieQueue = null;
        GenericNode<string> movieTail = null;

        public void Enqueue(int data)
        {
            var node = new GenericNode<int>()
            {
                Data = data
            };

            if (head == null)
            {
                tail = node;
                head = tail;
            }
            else
            {
                tail.Next = node;
                tail = tail.Next;
            }
        }

        public void Dequeue()
        {
            if (head != null)
                head = head.Next;
        }

        public void EnqueueMovie(string data)
        {
            var node = new GenericNode<string>()
            {
                Data = data
            };

            if (movieTail == null)
            {
                movieTail = node;
                movieQueue = movieTail;
            }
            else
            {
                movieTail.Next = node;
                movieTail = movieTail.Next;
            }
        }
    }
}
