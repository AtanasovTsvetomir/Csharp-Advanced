using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leftSockSequance = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] rightSockSequance = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> leftSocks = new Stack<int>(leftSockSequance);
            Queue<int> rightSocks = new Queue<int>(rightSockSequance);
            List<int> pairs = new List<int>();


            for (int i = 0; i < rightSockSequance.Length; i++)
            {
                int currentLeftSock = leftSocks.Peek();
                int currentRighttSock = rightSocks.Peek();

                if (currentLeftSock > currentRighttSock)
                {
                    int pair = currentRighttSock + currentLeftSock;
                    pairs.Add(pair);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                }
                else if (currentRighttSock > currentLeftSock)
                {
                    leftSocks.Pop();
                }
                else if (currentLeftSock == currentRighttSock)
                {
                    rightSocks.Dequeue();
                    leftSocks.Pop();
                    leftSocks.Push(currentLeftSock + 1);
                }
            }

            Console.WriteLine(pairs.Max());

            foreach (var pair in pairs)
            {
                Console.Write(pair + " ");
            }
        } 
    }
}
