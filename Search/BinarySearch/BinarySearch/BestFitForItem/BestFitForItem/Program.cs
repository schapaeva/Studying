using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFitForItem
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] boxes = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int itemSize = Int32.Parse(Console.ReadLine());

            int maxSize = boxes[boxes.Length -1];
            string errorMessage;

            if (CheckSizeInput(itemSize, maxSize, out errorMessage))
                Console.WriteLine("Best fit for this item is box of size " + FindBestBoxSize(boxes, itemSize).ToString());
            else
                Console.WriteLine(errorMessage);
            Console.ReadKey();
        }

        public static int FindBestBoxSize(int[] boxes, int itemSize)
        {
            int min = 0, max = boxes.Length - 1;
            while (min <= max)
            {
                int middle = (max + min) / 2;
                if (itemSize == boxes[middle])
                    return middle;
                if (itemSize < boxes[middle])
                {
                    max = middle - 1;
                }
                else if (itemSize > boxes[middle])
                {
                    min = middle + 1;
                }
            }
            return boxes[max + 1];
        }

        public static bool CheckSizeInput(int itemSize, int maxSize, out string errorMessage)
        {
            errorMessage = "";
            if (itemSize < 0)
            {
                errorMessage = "Item size should be more 0.";
                return false;
            }
            else if (itemSize > maxSize)
            {
                errorMessage = "There is no box that can fit this item. Max size of the box is " + maxSize.ToString();
                return false;
            }
            return true;
        }

    }
}
