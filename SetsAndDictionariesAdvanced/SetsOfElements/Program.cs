using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstSetSizes = sizes[0];
            int secondSetSizes = sizes[1];

            for (int i = 0; i < firstSetSizes; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                firstSet.Add(currentNumber);
            }

            for (int i = 0; i < secondSetSizes; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                secondSet.Add(currentNumber);
            }

            foreach (var currentItem in firstSet)
            {
                if (secondSet.Contains(currentItem))
                {
                    Console.Write(currentItem + " ");
                }
            }
        }
    }
}
