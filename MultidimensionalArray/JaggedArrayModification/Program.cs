using System;
using System.Linq;

namespace JaggedArrayModification
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

                jagged[row] = new int[currentRow.Length];

                for (int col = 0; col < currentRow.Length; col++)
                {
                    jagged[row][col] = currentRow[col];
                }
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command.ToLower() == "end")
                {
                    break;
                }

                var commandParts = command.Split(" ");

                string commandOperator = command[0].ToString();
                var commandRow = int.Parse(commandParts[1]);
                var commandCol = int.Parse(commandParts[2]); 
                var value = int.Parse(commandParts[3]);

                if (commandRow < 0
                    || commandRow >= jagged.Length
                    || commandCol < 0
                    || commandCol >= jagged[commandRow].Length
                    )
                {
                    Console.WriteLine("Invalid cordinates");
                }

                if (commandOperator == "Add")
                {
                    jagged[commandRow][commandCol] += value;
                }
                else if (commandOperator == "Substract")
                {
                    jagged[commandRow][commandCol] -= value;
                }
            }
            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
