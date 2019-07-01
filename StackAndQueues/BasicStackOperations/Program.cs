using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfElements = numbers[0];
            int numberOfElementsToPop = numbers[1];
            int numberToLook = numbers[2];

            int[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>(elements);

            for (int i = 0; i < numberOfElementsToPop; i++)
            {
                    stackOfNumbers.Pop();
            }

            if (stackOfNumbers.Contains(numberToLook))
            {
                Console.WriteLine("true");
            }
            else if (stackOfNumbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stackOfNumbers.Min());
            }
        }
    }
}
