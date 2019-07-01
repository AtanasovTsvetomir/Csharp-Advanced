using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stackParenteses = new Stack<char>();

            char[] input = Console.ReadLine()
                .ToCharArray();

            char[] openPareneteses = new char[] { '(', '{', '[' };

            bool isValid = true;

            foreach (var item in input)
            {
                if (openPareneteses.Contains(item))
                {
                    stackParenteses.Push(item);
                    continue;
                }

                if (stackParenteses.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackParenteses.Peek() == '(' && item == ')')
                {
                    stackParenteses.Pop();
                }
                else if (stackParenteses.Peek() == '{' && item == '}')
                {
                    stackParenteses.Pop();
                }
                else if (stackParenteses.Peek() == '[' && item == ']')
                {
                    stackParenteses.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
