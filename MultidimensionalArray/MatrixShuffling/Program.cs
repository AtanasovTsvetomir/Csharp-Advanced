using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];

                matrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] != "swap")
                {

                }

                input = Console.ReadLine();
            }
        }
    }
}
