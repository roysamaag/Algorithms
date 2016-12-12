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
            var linkedList = new LinkedList();
            //linkedList.Create();

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

            Console.WriteLine("");
            Console.WriteLine("Sort");
            linkedList.Sort();

            Console.ReadKey();
        }
    }
}
