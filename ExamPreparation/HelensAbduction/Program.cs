using System;

namespace HelensAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // --Read the input
            // --Energy, fieldRow, fieldi
            // --Initialize matrix 
            // --While Paris alive and not won
            // --Process turn
            // --Spawn spartans
            // -- Move Paris
            // --Check next position
            // --S -> Decrease energy
            // --H -> Win the game
            // Print Output

            int energy = int.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());

            char[][] field = new char[rowsCount][];

            InitializeMatrix(field);

        }

        private static void InitializeMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = Console.ReadLine()
                .ToCharArray();

                for (int i = 0; i < currentRow.Length; i++)
                {
                    char currentSymbol = currentRow[i];
                }

                field[row] = currentRow;
            }
        }
    }
}
