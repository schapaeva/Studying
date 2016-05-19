using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                int[] line = Array.ConvertAll(temp, Int32.Parse);
                if (line.Length != n)
                    throw new Exception("Matrix should be size of " + n.ToString());
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i,j] = line[j];
                }
            }
            PrintSpiral(matrix);
            PrintNormal(matrix);
            Console.ReadKey();
        }

        public static void PrintSpiral(int[,] matrix)
        {
            Console.Write("\n\n");
            int i, startRowInd = 0, endRowInd = matrix.GetLength(0), startColumnInd = 0, endColumnInd = matrix.GetLength(1);
            //main loop
            while (startRowInd < endRowInd && startColumnInd < endColumnInd)
            {
                //print first row
                for (i = startColumnInd; i < endColumnInd; i++)
                    Console.Write(matrix[startRowInd, i] + " ");
                startRowInd++;
                //print last column
                for (i = startRowInd; i < endRowInd; i++)
                    Console.Write(matrix[i, endColumnInd -1] + " ");
                endColumnInd--;
                //print last row
                if (startRowInd < endRowInd)
                {
                    for (i = endColumnInd-1; i >= startColumnInd; i--)
                        Console.Write(matrix[endRowInd -1, i] + " ");
                    endRowInd--;
                }
                //print first column
                if (startColumnInd < endColumnInd)
                {
                    for (i = endRowInd -1; i >= startRowInd; i--)
                        Console.Write(matrix[i, startColumnInd] + " ");
                    endColumnInd++;
                }
            }
        }
        public static void PrintNormal(int[,] matrix)
        {
            Console.Write("\n\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
