using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                var entry = Console.ReadLine();

                names.Add(entry);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
