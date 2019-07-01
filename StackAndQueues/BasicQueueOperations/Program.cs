using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] givenElements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> elements = new Queue<int>(givenElements);

            int elementsToDequeue = commands[1];
            int elementToLook = commands[2];

            for (int i = 0; i < elementsToDequeue; i++)
            {
                elements.Dequeue();
            }

            if (elements.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (elements.Count <= 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(elements.Min());
            }
        }
    }
}