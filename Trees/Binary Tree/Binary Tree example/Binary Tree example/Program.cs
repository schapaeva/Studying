using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_example
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree b = new BinaryTree();

            b.Insert(4);
            b.Insert(6);
            b.Insert(3);
            b.Insert(0);
            b.Insert(5);
            b.Insert(8);
            b.Insert(12);
            b.Insert(20);
            b.Insert(17);

            BinaryTree a = new BinaryTree();

            a.Insert(4);
            a.Insert(6);
            a.Insert(3);
            a.Insert(0);
            a.Insert(5);
            a.Insert(8);
            a.Insert(12);
            a.Insert(21);
            a.Insert(17);

            //Console.WriteLine("Height: " + b.GetHeight(b.root).ToString());
            Console.WriteLine(b.IsSameTree(b.root, a.root).ToString());

            //b.Display();

            Console.ReadLine();
            
        }
    }
}
