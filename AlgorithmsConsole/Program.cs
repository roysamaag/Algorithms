using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings strings = new Strings();
            //Console.WriteLine(strings.ReverseStringQuick("str"));
            //Console.WriteLine(strings.ReverseStringQuick("david roy"));
            //Console.WriteLine(strings.NeedleInHayStack("A toyota, race fast, safe car, a toyota", "ast"));

            //Console.WriteLine(strings.Occurs("A toyota, raroyce fast, roy sam s roy tafe car, a toyroyota", " roy "));

            //Console.WriteLine(strings.ReverseStringByChars("The quick brown fox jumped over the lazy dog"));
            //Console.WriteLine(strings.ReverseStringByWords("The quick brown fox jumped over the lazy dog"));
            //Console.WriteLine(strings.IsPalindrome("Able was I ere, I saw elba"));
            //Console.WriteLine(strings.IsPalindromeByChar("Able was I ere, I saw elba"));

            Problems p = new Problems();
            Console.WriteLine(p.Fibonacci_Dynamic(9));


            //Queue q = new Queue();
            //for (int i = 0; i < 1000000; i++)
            //    q.Enqueue(i);

            //int t = 0;

            //for (int i = 0; i < 1000000; i++)
            //     t = q.Dequeue();


            var linkedList = new LinkedList();
            linkedList.Create();

            //Console.WriteLine("Insert in Front");
            //linkedList.InsertFront(new Node { Name = "*Inserted*" });

            //Console.WriteLine("");
            //Console.WriteLine("Insert at End");
            //linkedList.InsertEnd(new Node { Name = "*Inserted*" });

            //Console.WriteLine("");
            //Console.WriteLine("Insert after Position Fourth");
            //linkedList.InsertAfterPosition(new Node { Name = "*Inserted*" }, "Fourth");

            //Console.WriteLine("");
            //Console.WriteLine("Insert before Position Fourth");
            //linkedList.InsertBeforePosition(new Node { Name = "*Inserted*" }, "Fourth");

            //Console.WriteLine("");
            //Console.WriteLine("Delete Position Sixth");
            //linkedList.Delete("Sixth");

            //Console.WriteLine("");
            //Console.WriteLine("Delete Front Node");
            //linkedList.DeleteFrontNode();


            //Console.WriteLine("");
            //Console.WriteLine("Delete Tail Node");
            //linkedList.DeleteTailNode();

            //Console.WriteLine("");
            //Console.WriteLine("Sort");
            //linkedList.Sort();

            Console.ReadKey();
        }
    }
}
