using System;

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
            tree.Insert(new Node(22));
            tree.Insert(new Node(40));
            tree.Insert(new Node(60));
            tree.Insert(new Node(95));
            tree.Insert(new Node(11));
            tree.Insert(new Node(3));
            tree.Insert(new Node(16));
            tree.Insert(new Node(63));
            tree.Insert(new Node(67));
            Console.Write("Binery Search Tree :");
            tree.Display();
            
            Console.ReadLine();
        }
    }
}
