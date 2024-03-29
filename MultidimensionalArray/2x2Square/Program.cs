﻿using System;
using System.Linq;

namespace _2x2Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int[,] arr = new int[dim[0], dim[1]];

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = tokens[col];
                }
            }
        }
    }
}
