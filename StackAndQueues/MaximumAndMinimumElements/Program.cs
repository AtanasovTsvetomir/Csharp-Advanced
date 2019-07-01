using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < countOfCommands; i++)
            {
                int[] givenCommands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = givenCommands[0];

                if (command == 1)
                {
                    stack.Push(givenCommands[1]);
                }
                else if (command == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (command == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
