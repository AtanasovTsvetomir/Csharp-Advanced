using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBotique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothingValues = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(clothingValues);

            int rackCapacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int currentRack = 0;
            int currentValue = 0;

            for (int i = 0; i < clothingValues.Length; i++)
            {
                if (stack.Count > 0)
                {
                    currentValue = stack.Peek();
                    stack.Pop();
                }

                    currentRack += currentValue;

                if (currentRack == rackCapacity)
                {
                    if (stack.Count > 0)
                    {
                        racks++;
                        currentRack = 0;
                    }
                }
                else if (currentRack > rackCapacity)
                {
                    currentRack -= currentValue;
                    racks++;
                    currentRack = 0;
                    currentRack += currentValue;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
