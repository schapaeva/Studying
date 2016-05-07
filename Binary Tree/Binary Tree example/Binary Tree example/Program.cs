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

            b.Insert(1);
            b.Insert(6);
            b.Insert(2);
            b.Insert(4);
            b.Insert(5);
            b.Insert(3);

            b.Display();

            Console.ReadLine();
            
        }
    }
}
