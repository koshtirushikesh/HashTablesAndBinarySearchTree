using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySarchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTreeClass tree = new BinarySearchTreeClass();
            tree.Insert(new Node(56));
            tree.Insert(new Node(30));
            tree.Insert(new Node(70));
            Console.Write("Binery Search Tree :");
            tree.Display();
            Console.ReadLine();
        }
    }
}
