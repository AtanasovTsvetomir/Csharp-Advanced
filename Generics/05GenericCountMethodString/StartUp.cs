using System;

namespace GenericCountMethodString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfBoxes = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < numberOfBoxes; i++)
            {
                string number = Console.ReadLine();
                box.Add(number);
            }

            string elementToCompare = Console.ReadLine();

            Console.WriteLine(box.Count(elementToCompare));
        }
    }
}
