using System;
using System.Collections.Generic;

namespace PereodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());

            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] entry = Console.ReadLine()
                     .Split();

                for (int j = 0; j < entry.Length; j++)
                {
                    set.Add(entry[j]);
                }
            }

            foreach (var element in set)
            {
                Console.Write(element + " ");
            }
        }
    }
}
