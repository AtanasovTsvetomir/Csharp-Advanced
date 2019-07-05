using System;
using System.Linq;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = currentRow;

            }

            //-------------------------------------------------

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = new int[currentRow.Length];

                for (int col = 0; col < currentRow.Length; col++)
                {
                    jagged[row][col] = currentRow[col];
                }
            }


            //-----------------------------------------------------

            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
