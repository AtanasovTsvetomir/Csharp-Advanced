using System;

namespace _02TronRacers
{
    // Solve with jagged array
    class Program
    {
        static char[][] field;
        static int firstPlayerRow;
        static int firstPlayerCol;
        static int secondPlayerRow;
        static int secondPlayerCol;

        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            field = new char[fieldSize][];

            // Fill the matrix and find players positions
            for (int row = 0; row < field.Length; row++)
            {
                char[] values = Console.ReadLine().ToCharArray();
                field[row] = new char[values.Length];

                for (int col = 0; col < values.Length; col++)
                {
                    field[row][col] = values[col];

                    if (field[row][col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }

                    if (field[row][col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }

            // Main logic of program
            while (true)
            {
                string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstPlayerDirection = directions[0];
                string secondPlayerDirection = directions[1];

                switch (firstPlayerDirection)
                {
                    case "up":
                        firstPlayerRow--;

                        if (firstPlayerRow < 0)
                        {
                            firstPlayerRow = field.Length - 1;
                        }

                        break;
                    case "down":
                        firstPlayerRow++;
                        if (firstPlayerRow == field.Length)
                        {
                            firstPlayerRow = 0;
                        }

                        break;
                    case "right":
                        firstPlayerCol++;
                        if (firstPlayerCol == field.Length)
                        {
                            firstPlayerCol = 0;
                        }

                        break;
                    case "left":
                        firstPlayerCol--;

                        if (firstPlayerCol < 0)
                        {
                            firstPlayerCol = field[firstPlayerRow].Length - 1;
                        }

                        break;
                }

                if (field[firstPlayerRow][firstPlayerCol] == 's')
                {
                    field[firstPlayerRow][firstPlayerCol] = 'x';
                    End();
                }
                else
                {
                    field[firstPlayerRow][firstPlayerCol] = 'f';
                }

                switch (secondPlayerDirection)
                {
                    case "up":
                        secondPlayerRow--;
                        if (secondPlayerRow < 0)
                        {
                            secondPlayerRow = field.Length - 1;
                        }

                        break;
                    case "down":
                        secondPlayerRow++;
                        if (secondPlayerRow == field.Length)
                        {
                            secondPlayerRow = 0;
                        }

                        break;
                    case "right":
                        secondPlayerCol++;
                        if (secondPlayerCol == field.Length)
                        {
                            secondPlayerCol = 0;
                        }

                        break;
                    case "left":
                        secondPlayerCol--;
                        if (secondPlayerCol < 0)
                        {
                            secondPlayerCol = field[secondPlayerRow].Length - 1;
                        }

                        break;
                }

                if (field[secondPlayerRow][secondPlayerCol] == 'f')
                {
                    field[secondPlayerRow][secondPlayerCol] = 'x';
                    End();
                }
                else
                {
                    field[secondPlayerRow][secondPlayerCol] = 's';
                }
            }
        }

        // Finish the program and print the matrix
        private static void End()
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write($"{field[row][col]}");
                }
                Console.WriteLine();
            }

            Environment.Exit(0);
        }
    }
}
