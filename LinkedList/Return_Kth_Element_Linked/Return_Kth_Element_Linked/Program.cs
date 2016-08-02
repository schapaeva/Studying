using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Kth_Element_Linked
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter linked list elements separated by space: ");
            string[] temp = Console.ReadLine().Split(' ');
            LinkedList<string> linkedList = new LinkedList<string>(temp);
            Console.Write("\nEnter k-th element from the END you want to show: ");
            int k = Int32.Parse(Console.ReadLine());

            if (k > 0 && k < linkedList.Count)
            {
                Console.WriteLine(Return_K(linkedList, k));
            }
            else
            {
                Console.WriteLine("Incorrect index.");
            }
            
            Console.ReadKey();            
        }

        public static string Return_K(LinkedList<string> list, int k)
        {
            return list.ElementAt(list.Count - k);
        }
    }
}
