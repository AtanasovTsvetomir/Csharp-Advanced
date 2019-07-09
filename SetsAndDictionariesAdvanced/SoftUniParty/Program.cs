using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = new SortedSet<string>();

            var entry = Console.ReadLine();

            while (entry.ToLower() != "party")
            {
                guests.Add(entry);

                entry = Console.ReadLine();
            }

            entry = Console.ReadLine();

            while (entry.ToLower() != "end")
            {
                guests.Remove(entry);

                entry = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }

        }
    }
}
